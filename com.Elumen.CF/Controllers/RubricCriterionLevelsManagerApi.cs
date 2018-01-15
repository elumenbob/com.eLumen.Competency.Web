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
    public class RubricCriterionLevelsManagerApiController : Controller
    { 

        /// <summary>
        /// The REST read request message for the getCFRubricCriterionLevel() API call.
        /// </summary>
        /// <remarks>This is a request to the service provider to provide the information for the specific Competency Framework Rubric Criterion Level. If the identified record cannot be found then the &#39;unknownobject&#39; status code must be reported.</remarks>
        /// <param name="sourcedId">The GUID that identifies the Competency Framework Rubric Criterion Level that is to be read from the service provider.</param>
        /// <response code="200">...tbd...</response>
        /// <response code="0">StatusInfo Error Report</response>
        [HttpGet]
        [Route("/ims/mrflsc/v1p0/CFRubricCriterionLevels/{sourcedId}")]
        [SwaggerOperation("GetCFRubricCriterionLevel")]
        [SwaggerResponse(200, type: typeof(CFRubricCriterionLevelType))]
        public virtual IActionResult GetCFRubricCriterionLevel([FromRoute]string sourcedId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CFRubricCriterionLevelType>(exampleJson)
            : default(CFRubricCriterionLevelType);
            return new ObjectResult(example);
        }
    }
}
