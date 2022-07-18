using AutoMapper;
using InternetBanking.Core.Applicacion.Dtos.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Account;
using InternetBanking.Core.Applicacion.ViewsModels.Beneficiary;
using InternetBanking.Core.Applicacion.ViewsModels.CashAdvance;
using InternetBanking.Core.Applicacion.ViewsModels.Client;
using InternetBanking.Core.Applicacion.ViewsModels.CreditCard;
using InternetBanking.Core.Applicacion.ViewsModels.Loan;
using InternetBanking.Core.Applicacion.ViewsModels.Payment;
using InternetBanking.Core.Applicacion.ViewsModels.Product;
using InternetBanking.Core.Applicacion.ViewsModels.ProductType;
using InternetBanking.Core.Applicacion.ViewsModels.Transaction;
using InternetBanking.Core.Applicacion.ViewsModels.User;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Applicacion.Mappings
{
    public class GeneralProfile: Profile
    {
        public GeneralProfile()
        {
            #region Account
            CreateMap<Account, AccountViewModel>()
                .ForMember(dest => dest.ClientName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Account, AccountSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Loans, opt => opt.Ignore())
                .ForMember(dest => dest.CashAdvances, opt => opt.Ignore())
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentsDestinationAccount, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentsOriginAccount, opt => opt.Ignore())
                .ForMember(dest => dest.TransactionsDestinationAccount, opt => opt.Ignore())
                .ForMember(dest => dest.TransactionsOriginAccount, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore());
            #endregion

            #region Beneficiary
            CreateMap<Beneficiary, BeneficiaryViewModel>()
                .ForMember(dest => dest.ClientName, opt => opt.Ignore())
                .ForMember(dest => dest.BeneficiaryName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Beneficiary, BeneficiarySaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.ClientBeneficiary, opt => opt.Ignore());

            #endregion

            #region CashAdvance
            CreateMap<CashAdvance, CashAdvanceViewModel>()
                .ForMember(dest => dest.ClientName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<CashAdvance, CashAdvanceSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.CreditCard, opt => opt.Ignore())
                .ForMember(dest => dest.Account, opt => opt.Ignore());
            #endregion

            #region Client
            CreateMap<Client, ClientViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Client, UserSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Accounts, opt => opt.Ignore())
                .ForMember(dest => dest.CashAdvances, opt => opt.Ignore())
                .ForMember(dest => dest.Beneficiaries, opt => opt.Ignore())
                .ForMember(dest => dest.ClientsBeneficiaries, opt => opt.Ignore())
                .ForMember(dest => dest.Transactions, opt => opt.Ignore())
                .ForMember(dest => dest.Payments, opt => opt.Ignore())
                .ForMember(dest => dest.Products, opt => opt.Ignore())
                .ForMember(dest => dest.Loans, opt => opt.Ignore())
                .ForMember(dest => dest.CreditCards, opt => opt.Ignore());
            #endregion

            #region CreditCard
            CreateMap<CreditCard, CreditCardViewModel>()
                .ForMember(dest => dest.ClientName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<CreditCard, CreditCardSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore())
                .ForMember(dest => dest.CashAdvances, opt => opt.Ignore());
            #endregion

            #region Loan
            CreateMap<Loan, LoanViewModel>()
                .ForMember(dest => dest.ClientName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Loan, LoanSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore())
                .ForMember(dest => dest.Account, opt => opt.Ignore());
            #endregion

            #region Payment
            CreateMap<Payment, PaymentViewModel>()
                .ForMember(dest => dest.ClientName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Payment, PaymentSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.DestinationAccount, opt => opt.Ignore())
                .ForMember(dest => dest.OriginAccount, opt => opt.Ignore());
            #endregion

            #region Product
            CreateMap<Product, ProductViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Product, ProductSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.ProductType, opt => opt.Ignore())
                .ForMember(dest => dest.Loan, opt => opt.Ignore())
                .ForMember(dest => dest.Transactions, opt => opt.Ignore())
                .ForMember(dest => dest.Account, opt => opt.Ignore());
            #endregion

            #region ProductType
            CreateMap<ProductType, ProductTypeViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<ProductType, ProductTypeSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore());
            #endregion

            #region Transaction
            CreateMap<Transaction, TransactionViewModel>()
                .ForMember(dest => dest.ClientName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Transaction, TransactionSaveViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Client, opt => opt.Ignore())
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.DestinationAccount, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore())
                .ForMember(dest => dest.OriginAccount, opt => opt.Ignore())
                .ForMember(dest => dest.Product, opt => opt.Ignore());
            #endregion

            #region User
            CreateMap<AuthentificationRequest, LoginViewModel>()
                .ForMember(dest => dest.HasError, opt => opt.Ignore())
                .ForMember(dest => dest.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<RegisterRequest, UserSaveViewModel>()
                .ForMember(dest => dest.HasError, opt => opt.Ignore())
                .ForMember(dest => dest.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ForgotPasswordRequest, ForgotPasswordSaveViewModel>()
              .ForMember(dest => dest.HasError, opt => opt.Ignore())
              .ForMember(dest => dest.Error, opt => opt.Ignore())
              .ReverseMap();

            CreateMap<ResetPasswordRequest, ResetPasswordSaveViewModel>()
              .ForMember(dest => dest.HasError, opt => opt.Ignore())
              .ForMember(dest => dest.Error, opt => opt.Ignore())
              .ReverseMap();

            #endregion
        }
    }
}
