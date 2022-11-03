using net_advanced_course.DAL.Settings;

namespace net_advanced_course.DAL
{
    public class LiteDbContextProvider
    {
        public readonly LiteDatabaseAsync Context;

        public LiteDbContextProvider(IOptions<LiteDbSettings> liteDbSettingOptions)
        {
            try
            {
                var db = new LiteDatabaseAsync(liteDbSettingOptions.Value.DatabasePath);
                if (db != null)
                {
                    Context = db;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can find or create LiteDb database.", ex);
            }
        }
    }
}
