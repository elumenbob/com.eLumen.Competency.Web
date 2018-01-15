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
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;
using com.eLumen.CF.Service.Models;
using Microsoft.Extensions.Options;
using com.eLumen.CF.Service.Configuration;
using com.eLumen.CF.Service.Mapper;
using com.eLumen.Competency.Data;
using com.eLumen.Competency.Domain;

namespace com.eLumen.CF.Service.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class RubricsManagerApiController : Controller
    {
        string _connectionString = null;

        public RubricsManagerApiController(IOptions<ApplicationOptions> connectionString)
        {
            _connectionString = connectionString.Value.elumen_connection;
        }


        /// <summary>
        /// The REST read request message for the getCFRubric() API call.
        /// </summary>
        /// <remarks>This is a request to the service provider to provide the information for the specific Competency Framework Rubric. If the identified record cannot be found then the &#39;unknownobject&#39; status code must be reported.</remarks>
        /// <param name="sourcedId">The GUID that identifies the Competency Framework Rubric that is to be read from the service provider.</param>
        /// <response code="200">...tbd...</response>
        /// <response code="0">StatusInfo Error Report</response>
        [HttpGet]
        [Route("/ims/mrflsc/v1p0/CFRubrics/{sourcedId}")]
        [SwaggerOperation("GetCFRubric")]
        [SwaggerResponse(200, type: typeof(CFRubricType))]
        public virtual IActionResult GetCFRubric([FromRoute]string sourcedId)
        {
            AssessmentContextData data = new AssessmentContextData(_connectionString);

            try
            {
                Assessment value = data.GetAssessment(sourcedId);

                if (value != null)
                {
                    var example = CFRubricMapper.Map(value.Rubric).ToJson();
                    return new ObjectResult(example);
                }
                else return new NotFoundObjectResult(sourcedId);
            }
            catch (Exception ex)
            {
                return new ContentResult()
                {
                    Content = ex.Message
                };
            }
        }
    }
}