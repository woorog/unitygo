using System.Threading.Tasks;

namespace Unity.Services.Multiplayer
{
    /// <summary>
    /// Extension methods of SessionOptions that can be used the manage the state of the matchmaking on the server side.
    /// </summary>
    public static class MatchmakerServerExtensions
    {
        /// <summary>
        /// Allows configuring the Backfilling of a session that was created through matchmaking and the Matchmaker
        /// service.
        /// </summary>
        /// <param name="options">The <see cref="SessionOptions"/> this extension method applies to.</param>
        /// <param name="enable">Enables or disables the backfilling for the session that will be created with the
        /// SessionOptions.</param>
        /// <param name="automaticallyRemovePlayers">Automatically remove the player from the state of the match or not.
        /// Setting this to true will enable automatically requesting players to backfill once a player leaves.</param>
        /// <param name="autoStart">Automatically starts or not the backfilling process at the creation of the sessions
        /// if it is not full.</param>
        /// <param name="backfillingLoopInterval">The interval in seconds between each approval of a backfilling
        /// ticket.</param>
        /// <typeparam name="T">The <see cref="SessionOptions">options</see>' type.</typeparam>
        /// <returns>The <see cref="SessionOptions"/>.</returns>
        public static T WithBackfillingConfiguration<T>(this T options, bool enable, bool automaticallyRemovePlayers = true, bool autoStart = true, int backfillingLoopInterval = 1) where T : SessionOptions
        {
            var connectionInfo = options.GetOption<ConnectionOption>();
            if (connectionInfo == null)
                throw new SessionException("No connection info defined on the session", SessionError.InvalidOperation);

            return options.WithOption(new MatchmakerOption(
                BackfillingConfiguration.WithBackfillingConfiguration(
                    enable,
                    automaticallyRemovePlayers,
                    autoStart,
                    backfillingLoopInterval)));
        }

        internal static T AllowBackfilling<T>(this T options) where T : SessionOptions
        {
            var connectionInfo = options.GetOption<ConnectionOption>();
            if (connectionInfo == null)
                return options.WithOption(new MatchmakerInitializationOption(false));

            return options.WithOption(new MatchmakerInitializationOption(true, $"{connectionInfo.Options.Ip}:{connectionInfo.Options.Port}"));
        }

        /// <summary>
        /// Starts the backfilling process of a session that was created through matchmaking and the Matchmaker service.
        /// </summary>
        /// <param name="session">The session to start the backfilling process on.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static Task StartBackfillingAsync(this ISession session)
        {
            return ((SessionHandler)session).GetModule<MatchmakerModule>().StartBackfillingAsync();
        }

        /// <summary>
        /// Stops the backfilling process of a session that was created through matchmaking and the Matchmaker service.
        /// </summary>
        /// <param name="session">The session to stop the backfilling process on.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static Task StopBackfillingAsync(this ISession session)
        {
            return ((SessionHandler)session).GetModule<MatchmakerModule>().StopBackfillingAsync();
        }
    }
}
