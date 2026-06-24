using Lib.Domain.Interface;

namespace Lib.Domain.Models;
class FileCuston : IFeliCustom
{
    public StreamReader NewFile(string path, FileMode mode, FileAccess access)
    {
        var arquivo = new FileStream(path, mode, access);
        var stream = new StreamReader(arquivo);
        return stream;
    } 

}