using Azure.Core;
using Library.Mapper;
using Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BR
{
    public static class Rental
    {
        static int curRentOutCount;
        static int maxBooksAllowed;
        static int potentialRentOutCount;
        static BizO.Member member;

        public static Library.BizO.Rental GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                //MessageBox.Show("Rental id parameter must not be empty");
                return null;
            }
            try
            {
                Library.BizO.Rental rec = Library.Cruder.Rental.GetById(id);
                return rec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static void getMemberInfo(Library.BizO.Rental rec)
        {
            string memberid = rec.MemberId;
            member = Cruder.Member.GetById(memberid);
            curRentOutCount = (int)member.CurrentRentOutCount;

            BizO.MemberType memberType = Cruder.MemberType.GetById(member.MemberTypeId);
            maxBooksAllowed = memberType.MaxBookAllowed;
        }

        public static Boolean SaveOrUpdate(Library.BizO.Rental rec, bool isNewRow){
            if (string.IsNullOrEmpty(rec.RentalId))
            {
                MessageBox.Show("Rental ID parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.MemberId))
            {
                MessageBox.Show("Member ID parameter must not be empty");
                return false;
            }
            if (string.IsNullOrEmpty(rec.UserId))
            {
                MessageBox.Show("User ID parameter must not be empty");
                return false;
            }
            


            BizO.Member member = Cruder.Member.GetById(rec.MemberId);
            BizO.User user = Cruder.User.GetById(rec.UserId);
            if(member == null  || user == null) {
                MessageBox.Show("Member or Librarian Id is invalid.");
                return false;
            }

            Library.BizO.Rental existingRental = isNewRow ? null : BR.Rental.GetById(rec.RentalId);

            foreach (BizO.RentalDetail rd in rec.RentalDetails)
            {
                // Check if the BookId exists in the Book entity
                var book = BR.Book.GetById(rd.BookId);
                if (book == null)
                {
                    MessageBox.Show($"'{rd.BookId}' is not a valid book ID");
                    return false;
                }

                // If it's a new row, check all books for availability
                // If it's an update, check availability only for newly added books
                bool isNewBook = isNewRow || (existingRental != null && !existingRental.RentalDetails.Any(x => x.BookId == rd.BookId));
                if (isNewBook && !BR.Book.isAvailable(rd.BookId))
                {
                    MessageBox.Show($"Book with ID {rd.BookId} is not available for rent");
                    return false;
                }
            }

            // Compare the current data with the existing rental
            if (!isNewRow && existingRental != null && AreRentalsEqual(rec, existingRental))
            {
                return true;
            }

            if(rec.RentalDetails != null)
            {
                getMemberInfo(rec);

                if (curRentOutCount > maxBooksAllowed)
                {
                    MessageBox.Show("This member's books rental is exceeding the maximum books allowed limit");
                    return false;
                }

                int rentOutCountChange = CalculateRentOutCountChange(rec, isNewRow);

                potentialRentOutCount = curRentOutCount + rentOutCountChange;

                if (potentialRentOutCount > maxBooksAllowed)
                {
                    MessageBox.Show("This member's books rental is exceeding the maximum books allowed limit");
                    return false;
                }

                member.CurrentRentOutCount = potentialRentOutCount >= 0 ? potentialRentOutCount : 0;
            }           

            try
            {
                Library.Cruder.Rental.Save(rec);
                Library.Cruder.Member.Save(member);
                UpdateBookAvailability(rec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        private static bool AreRentalsEqual(Library.BizO.Rental newRental, Library.BizO.Rental existingRental)
        {
            
            if (newRental.RentalId != existingRental.RentalId ||
                newRental.MemberId != existingRental.MemberId ||
                newRental.UserId != existingRental.UserId ||
                newRental.RentalDate != existingRental.RentalDate ||
                newRental.DateToReturn != existingRental.DateToReturn)
            {
                return false;
            }

            
            if (newRental.RentalDetails.Count != existingRental.RentalDetails.Count)
            {
                return false;
            }

            foreach (BizO.RentalDetail rd in newRental.RentalDetails)
            {
                BizO.RentalDetail matchingDetail = existingRental.RentalDetails
                    .FirstOrDefault(d => d.BookId == rd.BookId);

                if (matchingDetail == null ||
                    matchingDetail.IsReturned != rd.IsReturned ||
                    matchingDetail.ReturnDate != rd.ReturnDate ||
                    matchingDetail.ReturnStatus != rd.ReturnStatus)
                {
                    return false;
                }
            }

            return true;
        }

        private static int CalculateRentOutCountChange(Library.BizO.Rental rec, bool isNewRow)
        {
            int rentOutCountChange = 0;

            Library.BizO.Rental existingRental = BR.Rental.GetById(rec.RentalId);

            foreach (BizO.RentalDetail rd in rec.RentalDetails)
            {
                bool isNewBook = isNewRow || (existingRental != null && !existingRental.RentalDetails.Any(x => x.BookId == rd.BookId));
                Flags.ReturnStatus returnStatus = rd.ReturnStatus;

                if (isNewRow || (!isNewRow && isNewBook))
                {
                    switch (returnStatus)
                    {
                        case Flags.ReturnStatus.NotReturnedYet:
                        case Flags.ReturnStatus.Overdue:
                        case Flags.ReturnStatus.None:
                            rentOutCountChange++;
                            break;
                        default:                           
                            break;
                    }
                    
                }
                else
                {
                    BizO.RentalDetail existingRd = existingRental.RentalDetails.FirstOrDefault(x => x.BookId == rd.BookId);
                    if (rd.ReturnStatus == existingRd.ReturnStatus)
                    {
                        continue;
                    }
                    switch (returnStatus)
                    {

                        case Flags.ReturnStatus.Good:
                        case Flags.ReturnStatus.Lost:
                        case Flags.ReturnStatus.Damaged:
                            rentOutCountChange--;
                            break;
                        default:
                            break;
                    }
                }
            }

            return rentOutCountChange;
        }



        public static Boolean Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Rental id parameter must not be empty");
                return false;
            }
            try
            {
                Library.Cruder.Rental.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static void UpdateBookAvailability(BizO.Rental rental)
        {
            foreach(BizO.RentalDetail rd in rental.RentalDetails)
            {
                var newAvailabilityStatus = StatusMapper.MapReturnToAvailability(rd.ReturnStatus);
                
                string bookId = rd.BookId;
                var book = Library.BR.Book.GetById(bookId);

                if (book != null)
                {
                    book.AvailabilityStatus = newAvailabilityStatus;

                    Library.Cruder.Book.Save(book);

                }
            }
            
        }

        public static string CheckBookAvailability(BizO.Rental rental)
        {
            foreach(BizO.RentalDetail rd in rental.RentalDetails)
            {
                bool isBookAvailable = BR.Book.isAvailable(rd.BookId);
                if (!isBookAvailable) 
                {
                    return $"Book with ID {rd.BookId} is not available";
                }
            }
            return null;         
        }

        

    }


}
