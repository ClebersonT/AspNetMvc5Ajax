// ------------------------------------------------ -----------------------  
// <copyright file = "RazorAjaxController.cs" company = "None">  
// Copyright (c) Permitir a distribuição deste código.  
// </copyright>  
// <author> Asma Khalid </author>  
// ------------------------------------------------ -----------------------  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using RazorAjaxControl.Models;

namespace RazorAjaxControl.Controllers
{
    public class RazorAjaxController : Controller
    {
        #region Index view method.
        #region Get: /RazorAjax/Index  method.
        /// <summary>  
        /// Get: /RazorAjax/Index method.  
        /// </summary>  
        /// <returns>Return index view</returns>  
        public ActionResult Index()
        {
            try { }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }
            // Info.  
            return this.View();
        }
        #endregion
        #region POST: /RazorAjax/Index  
        /// <summary>  
        /// POST: /RazorAjax/Index  
        /// </summary>  
        /// <param name="model">Model parameter</param>  
        /// <returns>Return - RazorAjax content</returns>  
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(RazorAjaxViewModels model)
        {
            try
            {
                // Verification  
                if (ModelState.IsValid)
                {
                    // Info.  
                    return this.Json(new
                    {
                        EnableSuccess = true,
                        SuccessTitle = "Sucesso",
                        SuccessMsg = model.Text
                    });
                }
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }
            // Info  
            return this.Json(new
            {
                EnableError = true,
                ErrorTitle = "Erro",
                ErrorMsg = "Por favor, preencha o campo de texto!"
            });
        }
        #endregion 
        #endregion
    }
}