using CMS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.Common;

namespace CMS.Web.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult AddVehicle()
        { 
            var vehicle = new Vehicle
            {

            };
            return View(vehicle);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Add(Vehicle vehicle)
        {
            using (var db = new VehiclesDataEntities())
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }
            //return RedirectToAction();
            return RedirectToAction("AllVehicles");
        }

        [Authorize]
        public ActionResult AllVehicles()
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();
            using (var db = new VehiclesDataEntities())
            {
                listOfVehicles = db.Vehicles.ToList();
            }
            //return RedirectToAction();
            return View(listOfVehicles);
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            //var detailsVehicleViewModel = new Vehicle
            //{

            //};
            //detailsVehicleViewModel.Id = id;
            Vehicle detailsVehicleViewModel = null;
            using (var db = new VehiclesDataEntities())
            {
                detailsVehicleViewModel = db.Vehicles.Where(x => x.Id == id).FirstOrDefault();
            }
            
            return View(detailsVehicleViewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult UpdateMileage(Vehicle newVehicle)
        {
            using (var db = new VehiclesDataEntities())
            {
                Vehicle vehicle = db.Vehicles.First(m => m.Id == newVehicle.Id);
                vehicle.AverageMileage = newVehicle.AverageMileage;
                //db.Vehicles.First(m => m.Id == vehicle.Id).AverageMileage = vehicle.AverageMileage;
                db.SaveChanges();
            }
            return RedirectToAction("Details", new { id = newVehicle.Id });
        }

        [HttpPost]
        [Authorize]
        public ActionResult Calculate(Calculations calculations)
        {
            double result = AverageFuelConsumptionCalculator.CalculateFuelConsumptionLiters(calculations.Liters, calculations.Distance);
            calculations.Result = result;
            ViewBag.result = result;
           // return View(calculations);
            return View("FuelCalculator", calculations);
        }

        [HttpPost]
        [Authorize]
        public ActionResult FuelCalculator()
        {
            return View();
        }

        [Authorize]
        public ActionResult AddParts(int vehicleId)
        {
            AddConsumativeViewModel addConsumativeViewModel = new AddConsumativeViewModel
            {
                VehicleId = vehicleId
            };
            //addConsumativeViewModel.VehicleId = vehicleId;
            return View(addConsumativeViewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddOil(AddConsumativeViewModel addConsumativeViewModel)
        {
            using (var db = new VehiclesDataEntities())
            {
                addConsumativeViewModel.Oil.VehicleId = addConsumativeViewModel.VehicleId;
                db.Oils.Add(addConsumativeViewModel.Oil);

                db.SaveChanges();

                Vehicle car = db.Vehicles.Where(v => v.Id == addConsumativeViewModel.VehicleId).FirstOrDefault();
            }

            return RedirectToAction("AddParts", new { vehicleId = addConsumativeViewModel.VehicleId });
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddBelt(AddConsumativeViewModel addConsumativeViewModel)
        {
            using (var db = new VehiclesDataEntities())
            {
                addConsumativeViewModel.Belt.VehicleId = addConsumativeViewModel.VehicleId;
                db.Belts.Add(addConsumativeViewModel.Belt);

                db.SaveChanges();
            }
            return RedirectToAction("AddParts", new { vehicleId = addConsumativeViewModel.VehicleId });
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddBrake(AddConsumativeViewModel addConsumativeViewModel)
        {
            using (var db = new VehiclesDataEntities())
            {
                addConsumativeViewModel.Brake.VehicleId = addConsumativeViewModel.VehicleId;
                db.Brakes.Add(addConsumativeViewModel.Brake);

                db.SaveChanges();
            }
            return RedirectToAction("AddParts", new { vehicleId = addConsumativeViewModel.VehicleId });
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddFuelFilter(AddConsumativeViewModel addConsumativeViewModel)
        {
            using (var db = new VehiclesDataEntities())
            {
                addConsumativeViewModel.FuelFilter.VehicleId = addConsumativeViewModel.VehicleId;
                db.FuelFilters.Add(addConsumativeViewModel.FuelFilter);

                db.SaveChanges();
            }
            return RedirectToAction("AddParts", new { vehicleId = addConsumativeViewModel.VehicleId });
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddShock(AddConsumativeViewModel addConsumativeViewModel)
        {
            using (var db = new VehiclesDataEntities())
            {
                addConsumativeViewModel.Shock.VehicleId = addConsumativeViewModel.VehicleId;
                db.Shocks.Add(addConsumativeViewModel.Shock);

                db.SaveChanges();
            }
            return RedirectToAction("AddParts", new { vehicleId = addConsumativeViewModel.VehicleId });
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddTyre(AddConsumativeViewModel addConsumativeViewModel)
        {
            using (var db = new VehiclesDataEntities())
            {
                addConsumativeViewModel.Tyre.VehicleId = addConsumativeViewModel.VehicleId;
                db.Tyres.Add(addConsumativeViewModel.Tyre);

                db.SaveChanges();
            }
            return RedirectToAction("AddParts", new { vehicleId = addConsumativeViewModel.VehicleId });
        }
    }
}