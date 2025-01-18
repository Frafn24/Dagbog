using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagbog.Models
{
    public interface IDeAndEn
    {
        string EncodeToBase64(string plainText);
        string DecodeFromBase64(string base64EncodedData);
    }
}
