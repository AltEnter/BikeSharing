using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace BikeSharing.Helpers
{
    public static class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        #region 设置常量

        private const string AccessTokenKey = "access_token_key";
        private static readonly string s_accessTokenDefault = string.Empty;

        #endregion

        public static string AccessToken
        {
            get => AppSettings.GetValueOrDefault(AccessTokenKey, s_accessTokenDefault);
            set => AppSettings.AddOrUpdateValue(AccessTokenKey, value);
        }
    }
}
