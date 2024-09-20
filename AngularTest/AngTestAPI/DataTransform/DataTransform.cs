using AngTestAPI.Data;
using AngTestAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;

namespace AngTestAPI.NewFolder
{
    public class DataTransform : IDataTransform
    {
        private readonly ApiContext _context;
        public DataTransform(ApiContext context)
        {
            _context = context;
        }

        //API call to get all things back from the DB
        public API_Test[] GetValues()
        {
            var ret = _context.Api_Tests.ToArray();
            return ret;
        }

        //API call to add things to the DB
        public int PostValue(API_Test address) {
            if (address.Id == 0)
            {
                _context.Api_Tests.Add(address);
            }
            else
            {
                var inDb = _context.Api_Tests.Find(address.Id);

                if (inDb == null)
                {
                    return 404;
                }
                inDb = address;
            }
            _context.SaveChanges();
            return 200;
        }
    }
}
