using System;
using System.Collections.Generic;
using BimKon.Core.Models;

namespace BimKon.Core
{
    public interface ICsvHelper
    {
        List<SekolahDetailCsv> ReadSekolahDetail();
    }
}
