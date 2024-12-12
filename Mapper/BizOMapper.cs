using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity
{
    public class BizOMapper : Profile
    {
        public BizOMapper()
        {
            CreateMaps();
        }
        private void CreateMaps()
        {
            // Author
            CreateMap<Library.Entity.Author, Library.BizO.Author>(); //Entity to BizO
            CreateMap<Library.BizO.Author, Library.Entity.Author>()
                .ForMember(src => src.BookAuthors, dest => dest.Ignore()); //BizO to Entity

            // BookCategory
            CreateMap<Library.Entity.BookCategory, Library.BizO.BookCategory>(); 
            CreateMap<Library.BizO.BookCategory, Library.Entity.BookCategory>()
                .ForMember(src => src.Books, dest => dest.Ignore()); 

            //UserRole
            CreateMap<Library.Entity.UserRole, Library.BizO.UserRole>(); 
            CreateMap<Library.BizO.UserRole, Library.Entity.UserRole>()
                .ForMember(src => src.Users, dest => dest.Ignore());

            // User
            CreateMap<Library.Entity.User, Library.BizO.User>();
            CreateMap<Library.BizO.User, Library.Entity.User>()
                .ForMember(src => src.UserRole, dest => dest.Ignore())
                .ForMember(src => src.Rentals, dest => dest.Ignore());

            //MemberType
            CreateMap<Library.Entity.MemberType, Library.BizO.MemberType>(); 
            CreateMap<Library.BizO.MemberType, Library.Entity.MemberType>()
                .ForMember(src => src.Members, dest => dest.Ignore());

            //Member
            CreateMap<Library.Entity.Member, Library.BizO.Member>();
            CreateMap<Library.BizO.Member, Library.Entity.Member>()
                .ForMember(src => src.MemberType, dest => dest.Ignore())
                .ForMember(src => src.Rentals, dest => dest.Ignore());

            //Book
            CreateMap<Library.Entity.Book, Library.BizO.Book>();
            CreateMap<Library.BizO.Book, Library.Entity.Book>()
                .ForMember(src => src.BookAuthors, dest => dest.Ignore())
                .ForMember(src => src.BookCategory, dest => dest.Ignore())
                .ForMember(src => src.RentalDetails, dest => dest.Ignore());

            //BookAuthor
            CreateMap<Library.Entity.BookAuthor, Library.BizO.BookAuthor>();
            CreateMap<Library.BizO.BookAuthor, Library.Entity.BookAuthor>()
                .ForMember(src => src.Book, dest => dest.Ignore())
                .ForMember(src => src.Author, dest => dest.Ignore());

            //Rental
            CreateMap<Library.Entity.Rental, Library.BizO.Rental>();
            CreateMap<Library.BizO.Rental, Library.Entity.Rental>()
                .ForMember(src => src.Member, dest => dest.Ignore())
                .ForMember(src => src.User, dest => dest.Ignore());

            //Rental Detail
            CreateMap<Library.Entity.RentalDetail, Library.BizO.RentalDetail>();
            CreateMap<Library.BizO.RentalDetail, Library.Entity.RentalDetail>()
                .ForMember(src => src.Book, dest => dest.Ignore())
                .ForMember(src => src.Rental, dest => dest.Ignore());
        }
    }
}
