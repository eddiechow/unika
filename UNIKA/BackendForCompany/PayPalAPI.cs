using System.Collections.Generic;
using PayPal.Api;

namespace BackendForCompany
{
    class PayPalAPI
    {

        public static APIContext getApiContext()
        {
            Dictionary<string, string> config = new Dictionary<string, string>();
            config.Add("mode", "sandbox");

            string accessToken = new OAuthTokenCredential("Aewdx5OW1GMDzqAvrALOqQbly-wlzR9iimXtsLP69GACo9eY5XcTgMXwVxMnEnYYW4Od_ywcnIr73W6O", "EOT8HyKdVG2EH1yR6Rf1fYQPzqsHZNdJvxgIO4ycxkZpPdgXfecDcVJz3RBVEEpo2wtWcABKNWI5oi9M", config).GetAccessToken();

            APIContext apiContext = new APIContext(accessToken);
            apiContext.Config = config;

            return apiContext;
        }

    }
}
