using System.Threading.Tasks;

namespace Reporting.Interface
{
    public interface IPdfConverter
    {
        Task<byte[]> Convert<TModel>(string viewPath, TModel model);
    }
}
