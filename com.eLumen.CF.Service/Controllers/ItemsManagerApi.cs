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
    public class ItemsManagerApiController : Controller
    {
        string _connectionString = null;

        public ItemsManagerApiController(IOptions<ApplicationOptions> connectionString)
        {
            _connectionString = connectionString.Value.elumen_connection;
        }


        /// <summary>
        /// The REST read request message for the getCFItem() API call.
        /// </summary>
        /// <remarks>This is a request to the Service Provider to provide the specified Competency Framework Item.  If the identified record cannot be found then the &#39;unknownobject&#39; status code must be reported.</remarks>
        /// <param name="sourcedId">The GUID that identifies the Competency Framework Item that is to be read from the service provider.</param>
        /// <response code="200">...tbd...</response>
        /// <response code="0">StatusInfo Error Report</response>
        [HttpGet]
        [Route("/ims/mrflsc/v1p0/CFItems/{sourcedId}")]
        [SwaggerOperation("GetCFItem")]
        [SwaggerResponse(200, type: typeof(CFItemType))]
        public virtual IActionResult GetCFItem([FromRoute]string sourcedId)
        {
            CompetencyDefinitionData data = new CompetencyDefinitionData(_connectionString);

            if (!sourcedId.Contains('.')) return new BadRequestResult();

            string[] sourceValues = sourcedId.Split('.');
            CFItemType result = null;

            switch (sourceValues[0])
            {
                case "SLO":
                    SLO value = data.GetLearningOutcome(sourcedId);

                    if (value != null)
                    {
                        result = CFItemTypeMapper.Map(value);
                    }
                    break;
            }

            if (result == null) return new NotFoundObjectResult(sourcedId);

            return new ObjectResult(result.ToJson());
        }
    }
}
