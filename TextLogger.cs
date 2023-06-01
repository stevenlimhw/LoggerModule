using Microsoft.Extensions.Options;

namespace TradingEngineServer.Logging.LoggingConfiguration;
{
    public class TextLogger : AbstractLogger, ITextLogger
    {
        private readonly LoggerConfiguration _loggingConfiguration;
        public TextLogger(IOptions<LoggerConfiguration> loggingConfiguration) : base()
        {
            _loggingConfiguration = loggingConfiguration.Value ?? throw new ArgumentNullException(nameof(loggingConfiguration));
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        protected override void Log(LogLevel loglevel, string module, string message)
        {
            throw new NotImplementedException();
        }
    }
}