using System.Linq;
using AutoMapper;
using Narik.Common.Shared.Models;
using NarikDemo.Data.Model;
using NarikDemo.Modules.Demo._Account;
using NarikDemo.Modules.Demo._AccTransaction;
using NarikDemo.Modules.Demo._Branch;
using NarikDemo.Modules.Demo._Business;
using NarikDemo.Modules.Demo._CustomEntity;
using NarikDemo.Modules.Demo._Customer;
using NarikDemo.Modules.Demo._Department;
using NarikDemo.Modules.Demo._Employee;
using NarikDemo.Modules.Demo._Individual;
using NarikDemo.Modules.Demo._Officer;
using NarikDemo.Modules.Demo._Product;
using NarikDemo.Modules.Demo._ProductType;
using NarikDemo.Modules.Demo._Role;
using NarikDemo.Modules.Demo._UserAccount;

namespace NarikDemo.Modules.Demo
{
    public class NarikDemoMappingProfile : Profile
    {
        public NarikDemoMappingProfile()
        {
            CreateMap<UserAccount, ApplicationUser>()
                .ForMember(x => x.UserId, x => x.MapFrom(s => s.Id))
                .ForMember(x => x.Roles, x => x.MapFrom(s => s.UserAccountRoles.Select(r => r.RoleId.ToString())));

            CreateMap<UserAccountViewModel, UserAccount>();
            CreateMap<UserAccount, UserAccountViewModel>()
                .ForMember(x => x.Password, x => x.MapFrom(s => "$$default"));

            CreateMap<Branch, BranchViewModel>();
            CreateMap<BranchViewModel, Branch>();
            CreateMap<Branch, NarikDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.BranchId))
                .ForMember(x => x.Title, x => x.MapFrom(s => s.Name));

            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
            CreateMap<Product, ProductDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.ProductCd))
                .ForMember(x => x.Title, x => x.MapFrom(s => s.Name));

            CreateMap<ProductType, ProductTypeViewModel>();
            CreateMap<ProductTypeViewModel, ProductType>();
            CreateMap<ProductType, ProductTypeDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.ProductTypeCd))
                .ForMember(x => x.Title, x => x.MapFrom(s => s.Name));

            CreateMap<Employee, EmployeeViewModel>();
            CreateMap<EmployeeViewModel, Employee>();
            CreateMap<Employee, NarikDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.EmpId))
                .ForMember(x => x.Title, x => x.MapFrom(s => s.FirstName + " "+ s.LastName));

            CreateMap<Department, DepartmentViewModel>();
            CreateMap<DepartmentViewModel, Department>();
            CreateMap<Department, NarikDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.DeptId))
                .ForMember(x => x.Title, x => x.MapFrom(s => s.Name));

            CreateMap<Account, AccountViewModel>();
            CreateMap<AccountViewModel, Account>();
            CreateMap<Account, NarikDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.AccountId))
                .ForMember(x => x.Title, x => x.MapFrom(s => s.Cust.Individuals.Select(i => i.FirstName + " " + i.LastName).FirstOrDefault()));


            CreateMap<Customer, CustomerViewModel>();
            CreateMap<CustomerViewModel, CustomerDto>();
            CreateMap<Customer, CustomerDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.CustId))
                .ForMember(x => x.Title,
                    x => x.MapFrom(s => s.Individuals.Select(i => i.FirstName + " " + i.LastName).FirstOrDefault()));

            CreateMap<BusinessViewModel, Business>();
            CreateMap<Business, BusinessViewModel>().ForMember(x => x.CustomerTitle,
                x => x.MapFrom(s => s.Cust.Individuals.Select(i => i.FirstName + " " + i.LastName).FirstOrDefault()));

            CreateMap<EmployeeViewModel, Employee>();
            CreateMap<Employee, EmployeeViewModel>().
                ForMember(x => x.BranchTitle,x => x.MapFrom(s => s.AssignedBranch.Name)).
                ForMember(x => x.DepartmentTitle,x => x.MapFrom(s => s.Dept.Name)).
                ForMember(x => x.SuperiorEmployeeTitle,x => x.MapFrom(s => s.ParentSuperiorEmp.Title));

            CreateMap<ProductViewModel, Product>();
            CreateMap<Product, ProductViewModel>()
                .ForMember(x => x.ProductTypeTitle, x => x.MapFrom(s => s.ProductTypeCd1.Name));

            CreateMap<Account, AccountListViewModel>()
                .ForMember(x => x.ProductTitle, x => x.MapFrom(s => s.ProductCd1.Name))
                .ForMember(x => x.BranchTitle, x => x.MapFrom(s => s.OpenBranch.Name))
                .ForMember(x => x.EmployeeTitle, x => x.MapFrom(s => s.OpenEmp.Title))
                .ForMember(x => x.CustomerTitle, x => x.MapFrom(s => s.Cust.Individuals.Select(i => i.FirstName + " " + i.LastName).FirstOrDefault()));

            CreateMap<AccTransactionViewModel, AccTransaction>();
            CreateMap<AccTransaction, AccTransactionViewModel>()
                .ForMember(x => x.AccountTitle,
                    x => x.MapFrom(s =>
                        s.Account.Cust.Individuals.Select(i => i.FirstName + " " + i.LastName).FirstOrDefault()))
                .ForMember(x => x.ExecutionBranchtitle, x => x.MapFrom(s => s.ExecutionBranch.Name));

            CreateMap<CustomEntity, CustomEntityViewModel>();
            CreateMap<CustomEntityViewModel, CustomEntity>();

            CreateMap<Individual, IndividualViewModel>();
            CreateMap<IndividualViewModel, Individual>();

            CreateMap<Officer, OfficerViewModel>();
            CreateMap<OfficerViewModel, Officer>();

            CreateMap<Role, RoleViewModel>();
            CreateMap<RoleViewModel, Role>();

            CreateMap<Role, NarikDto>()
                .ForMember(x => x.Id, x => x.MapFrom(s => s.Id))
                .ForMember(x => x.Title, x => x.MapFrom(s => s.Title));
        }
    }
}
