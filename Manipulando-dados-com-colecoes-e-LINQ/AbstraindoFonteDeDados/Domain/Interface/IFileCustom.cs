namespace AbstraindoFonteDeDados.Domain.Interface;
    interface IFeliCustom
    {
        public StreamReader NewFile(string path, FileMode mode, FileAccess access);
    }
