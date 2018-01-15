/*
 * Machine Readable Framework for Learning Standards and Competencies Service OpenAPI (JSON) Definition
 *
 * The Machine Readable Framework for Learning Standards and Competencies Service enables the exchange of data between a Competency Records Service Provider and the consumers of the associated data. This service has been described using the IMS Model Driven Specification development approach: this being the Platform Specific Model (PSM) of the service.
 *
 * OpenAPI spec version: 1.0
 * Contact: lmattson@imsglobal.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using com.eLumen.CF.Models;

namespace com.eLumen.CF.Controllers
{ 
    /// <summary>
    /// Not implemented 
    /// </summary>
    public class AssociationsManagerApiController : Controller
    { 

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call.
        /// </summary>
        /// <remarks>This is a request to the Service Provider to provide the all of the Competency Associations for the specified CFItem.  If the identified record cannot be found then the &#39;unknownobject&#39; status code must be reported.</remarks>
        /// <param name="sourcedId">The GUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <response code="200">...tbd...</response>
        /// <response code="0">StatusInfo Error Report</response>
        [HttpGet]
        [Route("/ims/mrflsc/v1p0/CFItemAssociations/{sourcedId}")]
        [SwaggerOperation("GetCFItemAssociations")]
        [SwaggerResponse(200, type: typeof(CFAssociationSetType))]
        public virtual IActionResult GetCFItemAssociations([FromRoute]string sourcedId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CFAssociationSetType>(exampleJson)
            : default(CFAssociationSetType);
            return new ObjectResult(example);
        }
    }
}