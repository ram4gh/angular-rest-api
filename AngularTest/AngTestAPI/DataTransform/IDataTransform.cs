using AngTestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AngTestAPI.NewFolder
{
    public interface IDataTransform
    {
        API_Test[] GetValues();
        int PostValue(API_Test address);
    }
}