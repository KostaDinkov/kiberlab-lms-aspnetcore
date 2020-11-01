using System.Collections.Generic;

namespace KiberlabLMS.Services.Data
{
    public interface ICoursesService
    {
        IEnumerable<T> GetAll<T>();
    }
}