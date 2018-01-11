using SQLite;

namespace IsThis
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

