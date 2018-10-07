using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore_CRUD.Models.DTO;
using NetCore_CRUD.Repository.BLO;
using NetCore_CRUD.ViewModel.Out;

namespace NetCore_CRUD.WebApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductBLL BO;
        public ProductApiController(IProductBLL BO)
        {
            this.BO = BO;
        }
        [HttpPost]
        public ApiResponse Create(Product item)
        {
            ApiResponse result;
            try
            {
                this.BO.Create(item);
                result = new ApiResponse(HttpStatusCode.OK, "Success", null);
            }
            catch (Exception ex)
            {
                string err = string.Format("{0} 發生: {1}", this.ControllerContext.RouteData.ToString(), ex.Message);
                result = new ApiResponse(HttpStatusCode.BadRequest, null, err);
            }
            return result;
        }
        [HttpPost]
        public ApiResponse Update(Product item)
        {
            ApiResponse result;
            try
            {
                this.BO.Update(item);
                result = new ApiResponse(HttpStatusCode.OK, "Success", null);
            }
            catch (Exception ex)
            {
                string err = string.Format("{0} 發生: {1}", this.ControllerContext.RouteData.ToString(), ex.Message);
                result = new ApiResponse(HttpStatusCode.BadRequest, null, err);
            }
            return result;
        }
        [HttpPost]
        public ApiResponse Delete(Product item)
        {
            ApiResponse result;
            try
            {
                this.BO.Delete(item);
                result = new ApiResponse(HttpStatusCode.OK, "Success", null);
            }
            catch (Exception ex)
            {
                string err = string.Format("{0} 發生: {1}", this.ControllerContext.RouteData.ToString(), ex.Message);
                result = new ApiResponse(HttpStatusCode.BadRequest, null, err);
            }
            return result;
        }
        [HttpGet]
        public ApiResponse GetAll()
        {
            ApiResponse result;
            try
            {
                result = new ApiResponse(HttpStatusCode.OK, this.BO.GetAll(), null);
            }
            catch (Exception ex)
            {
                string err = string.Format("{0} 發生:{1}", this.ControllerContext.RouteData.ToString(), ex.Message);
                result = new ApiResponse(HttpStatusCode.BadRequest, null, err);
            }
            return result;
        }
        [HttpGet]
        public ApiResponse GetById(string id)
        {
            ApiResponse result;
            try
            {
                result = new ApiResponse(HttpStatusCode.OK, this.BO.GetById(id), null);
            }
            catch (Exception ex)
            {
                string err = string.Format("{0} 發生:{1}", this.ControllerContext.RouteData.ToString(), ex.Message);
                result = new ApiResponse(HttpStatusCode.BadRequest, null, err);
            }
            return result;
        }

    }
}