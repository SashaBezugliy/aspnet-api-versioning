﻿#if WEBAPI
namespace Microsoft.Web.Http.Versioning
#else
namespace Microsoft.AspNetCore.Mvc.Versioning
#endif
{
#if WEBAPI
    using IActionResult = System.Net.Http.HttpResponseMessage;
#else
    using Http;
#endif
    using System;

    /// <summary>
    /// Defines the behavior of an object that provides HTTP error responses related to API versioning.
    /// </summary>
#if !WEBAPI
    [CLSCompliant( false )]
#endif
    public interface IErrorResponseProvider
    {
        /// <summary>
        /// Creates and returns a new HTTP 400 (Bad Request) given the provided context.
        /// </summary>
        /// <param name="context">The <see cref="ErrorResponseContext">error context</see> used to generate response.</param>
        /// <returns>The generated <see cref="IActionResult">response</see>.</returns>
        IActionResult BadRequest( ErrorResponseContext context );

        /// <summary>
        /// Creates and returns a new HTTP 405 (Method Not Allowed) given the provided context.
        /// </summary>
        /// <param name="context">The <see cref="ErrorResponseContext">error context</see> used to generate response.</param>
        /// <returns>The generated <see cref="IActionResult">response</see>.</returns>
        IActionResult MethodNotAllowed( ErrorResponseContext context );
    }
}