using Nop.Core.Domain.Common;
using Nop.Web.Models.Common;

namespace Nop.Web.Extensions
{
    public static class MappingExtensions
    {
        //address
        public static Address ToEntity(this AddressModel model, bool trimFields = true)
        {
            if (model == null)
                return null;

            var entity = new Address();
            return ToEntity(model, entity, trimFields);
        }

        public static Address ToEntity(this AddressModel model, Address destination, bool trimFields = true)
        {
            if (model == null)
                return destination;

            if (trimFields)
            {
                if (model.FirstName != null)
                    model.FirstName = model.FirstName.Trim();
                if (model.LastName != null)
                    model.LastName = model.LastName.Trim();
                if (model.Email != null)
                    model.Email = model.Email.Trim();
                if (model.Company != null)
                    model.Company = model.Company.Trim();
                if (model.County != null)
                    model.County = model.County.Trim();
                if (model.City != null)
                    model.City = model.City.Trim();
                if (model.Address1 != null)
                    model.Address1 = model.Address1.Trim();
                if (model.Address2 != null)
                    model.Address2 = model.Address2.Trim();
                if (model.ZipPostalCode != null)
                    model.ZipPostalCode = model.ZipPostalCode.Trim();
                if (model.PhoneNumber != null)
                    model.PhoneNumber = model.PhoneNumber.Trim();
                if (model.FaxNumber != null)
                    model.FaxNumber = model.FaxNumber.Trim();
            }
            destination.Id = model.Id;
            destination.FirstName = model.FirstName;
            destination.LastName = model.LastName;
            destination.Email = model.Email;
            destination.Company = model.Company;
            destination.CountryId = model.CountryId;
            destination.StateProvinceId = model.StateProvinceId;
            destination.County = model.County;
            destination.City = model.City;
            destination.Address1 = model.Address1;
            destination.Address2 = model.Address2;
            destination.ZipPostalCode = model.ZipPostalCode;
            destination.PhoneNumber = model.PhoneNumber;
            destination.FaxNumber = model.FaxNumber;

            return destination;
        }

        public static AddressModel ToModel(this Address entity, AddressModel destination, bool trimFields = true)
        {
            if (entity == null)
                return destination;

            if (trimFields)
            {
                if (entity.FirstName != null)
                    entity.FirstName = entity.FirstName.Trim();
                if (entity.LastName != null)
                    entity.LastName = entity.LastName.Trim();
                if (entity.Email != null)
                    entity.Email = entity.Email.Trim();
                if (entity.Company != null)
                    entity.Company = entity.Company.Trim();
                if (entity.County != null)
                    entity.County = entity.County.Trim();
                if (entity.City != null)
                    entity.City = entity.City.Trim();
                if (entity.Address1 != null)
                    entity.Address1 = entity.Address1.Trim();
                if (entity.Address2 != null)
                    entity.Address2 = entity.Address2.Trim();
                if (entity.ZipPostalCode != null)
                    entity.ZipPostalCode = entity.ZipPostalCode.Trim();
                if (entity.PhoneNumber != null)
                    entity.PhoneNumber = entity.PhoneNumber.Trim();
                if (entity.FaxNumber != null)
                    entity.FaxNumber = entity.FaxNumber.Trim();
            }
            destination.Id = entity.Id;
            destination.FirstName = entity.FirstName;
            destination.LastName = entity.LastName;
            destination.Email = entity.Email;
            destination.Company = entity.Company;
            destination.CountryId = entity.CountryId;
            destination.StateProvinceId = entity.StateProvinceId;
            destination.County = entity.County;
            destination.City = entity.City;
            destination.Address1 = entity.Address1;
            destination.Address2 = entity.Address2;
            destination.ZipPostalCode = entity.ZipPostalCode;
            destination.PhoneNumber = entity.PhoneNumber;
            destination.FaxNumber = entity.FaxNumber;

            return destination;
        }
    }
}