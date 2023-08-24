using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Domain.Interfaces.Validators
{
    public interface ICarValidator
    {
        bool IsCarExists(string carId);
        bool IsCarExistsByVin(string vin);
    }
}
