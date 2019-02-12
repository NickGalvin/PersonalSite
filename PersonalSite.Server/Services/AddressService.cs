using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalSite.Shared.Order;
namespace PersonalSite.Server.Services
{
    public interface IAddressService
    {
        Address GetAddressById(string id);
        List<Address> GetAllAddressByEmail { get; set; }
        List<Address> GetAllAddressByUserId { get; set; }
        Address CreateAddress(Address address);
        Address UpdateAddress(Address address);
        Address DeleteAddress(string addressId);
    }

    public class AddressService
    {


    }
}
