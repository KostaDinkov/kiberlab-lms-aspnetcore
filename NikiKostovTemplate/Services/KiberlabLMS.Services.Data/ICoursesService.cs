using System.Collections.Generic;
using System.Net.Mime;

namespace KiberlabLMS.Services.Data
{
    public interface ICoursesService
    {
        IEnumerable<T> GetAll<T>();

        T GetById<T>(string id);
    }
}