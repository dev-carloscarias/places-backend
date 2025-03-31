using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Places.Domain.Dtos;

public class EmailResponse
{
    /// <summary>
    /// The status code returned.
    /// </summary>
    private HttpStatusCode _statusCode;

    public HttpStatusCode StatusCode
    {
        get
        {
            return this._statusCode;
        }

        set
        {
            this._statusCode = value;
        }
    }

    /// <summary>
    /// Gets a value indicating whether Status Code of this response indicates success.
    /// </summary>
    public bool IsSuccessStatusCode
    {
        get { return ((int)StatusCode >= 200) && ((int)StatusCode <= 299); }
    }
}