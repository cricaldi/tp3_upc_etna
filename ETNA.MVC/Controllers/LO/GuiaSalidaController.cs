using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ETNA.Common;
using ETNA.MVC.Models.LO;
using WebMatrix.WebData;
using AutoMapper;

namespace ETNA.MVC.Controllers.LO
{
    public class GuiaSalidaController : Controller
    {

        public ActionResult Almacenes()
        {
            //Invocamos al servicio
            var service = new LogisticaServices.EntradasYSalidasServiceClient();

            //Como código de empleado le pasamos el current user id (es importante que coincida con el empleado id)
            var almacenesDto = service.ObtenerAlmacenesPorEmpleado(WebSecurity.CurrentUserId);

            if (almacenesDto.Any())
            {
                //Si el usuario solo tiene un almacén asignado, obviamos este paso
                if (almacenesDto.Count() == 1)
                {
                    return RedirectToAction("Solicitudes", new { id = almacenesDto[0].Id });
                }

                //Mapeamos el DTO a nuestro modelo (de forma automática o a mano, dependiendo de nuestra necesidad)
                var model = Mapper.Map<List<AlmacenViewModel>>(almacenesDto);
                return View(model);
            }

            @ViewBag.Message = "El usuario no cuenta con ningún almacén asociado.";
            return View("Error");
        }

        public ActionResult Solicitudes(int id)
        {
            //Almacenamos temporalmente el id de almacén
            @ViewBag.IdAlmacen = id;

            //Buscamos algún mensaje de éxito (si venimos de dar de alta una guía de entrada)
            if (TempData.ContainsKey("Message"))
                @ViewBag.Message = TempData["Message"];

            //Invocamos al servicio
            var service = new LogisticaServices.EntradasYSalidasServiceClient();

            //Como código de empleado le pasamos el current user id (es importante que coincida con el empleado id)
            var solicitudesDto = service.ObtenerSolicitudesSalida(0, (int)Enums.EstadoSolicitudSalida.Aprobada,
                DateTime.MinValue, DateTime.MinValue, 0, "Parcial", "Av. Benavides 435", "Aceros S.A.");

            //Mapeamos el DTO a nuestro modelo (de forma automática o a mano, dependiendo de nuestra necesidad)
            var lista = Mapper.Map<List<ListaSolicitudSalidaViewModel>>(solicitudesDto);
            var model = new FiltradoSolicitudesSalidaViewModel();
            model.ListaInicial = lista;
            return View(model);
        }

        public ActionResult Atender(int id, int idAlmacen)
        {
            @ViewBag.IdSolicitud = id;
            @ViewBag.IdAlmacen = idAlmacen;
            TempData["Message"] = "";

            //Invocamos al servicio
            var service = new LogisticaServices.EntradasYSalidasServiceClient();

            //Como código de empleado le pasamos el current user id (es importante que coincida con el empleado id)
            var solicitudesDto = service.ObtenerSolicitudSalida(id);

            //Mapeamos el DTO a nuestro modelo (de forma automática o a mano, dependiendo de nuestra necesidad)
            var model = Mapper.Map<SolicitudSalidaViewModel>(solicitudesDto);
            return View(model);
        }

        [HttpPost]
        public ActionResult Atender(AltaGuiaSalidaModel model)
        {
            //Invocamos al servicio
            var service = new LogisticaServices.EntradasYSalidasServiceClient();

            if (model.Rechazar)
            {
                //Damos de alta la guía de entrada
                var success = service.RechazarGuiaSalida(model.IdSolicitud, model.Observaciones);
                if (success)
                {
                    TempData["Message"] =
                        String.Format("Se rechazó correctamente la solicitud {0}", model.IdSolicitud);
                }
            }
            else
            {
                //Damos de alta la guía de entrada
                var success = service.GenerarGuiaSalida(model.IdSolicitud, model.IdSolicitud, WebSecurity.CurrentUserId);
                if (success)
                {
                    TempData["Message"] =
                        String.Format("Se generó correctamente la guía de salida para la solicitud {0}",
                            model.IdSolicitud);
                }
            }

            return RedirectToAction("Solicitudes", new { id = model.IdAlmacen });
        }

        // GET: /GuiaEntrada/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /GuiaSalida/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /GuiaSalida/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /GuiaSalida/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /GuiaSalida/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /GuiaSalida/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /GuiaSalida/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
