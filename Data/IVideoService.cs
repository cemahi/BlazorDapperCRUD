using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperCRUD.Data
{
    interface IVideoService
    {
        Task<bool> VideoInsert(Video video);
    }
}
