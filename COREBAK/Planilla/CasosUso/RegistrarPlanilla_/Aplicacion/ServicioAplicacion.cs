using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion.Constantes;
using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion.Dto;
using COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Dominio.Interface;
using COREBAK.Planilla.Entidad.Base;
using COREBAK.Planilla.Shared.CasosUso.ExistePlanilla.Aplicacion;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace COREBAK.Planilla.CasosUso.RegistrarPlanilla_.Aplicacion
{
    public class ServicioAplicacion(
        IRegistrarPlanillaRepository RegistrarPlanillaRepository
        , ExisteServicioAplicacion servicioAplicacion
    )
    {
        private readonly IRegistrarPlanillaRepository registrarPlanillaRepository = RegistrarPlanillaRepository;
        private readonly ExisteServicioAplicacion _existeServicio = servicioAplicacion;

        public async Task RegistrarPlanilla(RegistrarPlanillaDTO dto)
        {
            var fechaRegistro = DateTime.UtcNow;
            var usuarioRegistro = "JDEPAZE";
            Guid planillaId = Guid.Parse("459D4D0C-0D14-4BA2-AD3E-51B6A6EDCF1C");


            TwilioClient.Init(accountSid, authToken);

            var message = await MessageResource.CreateAsync(
                body: " \n Mission Produce te va la buenas noches." +
                "\n Te queremos comunicar que fuiste seleccionado para el puesto de desarrollador/funcional HCM." +
                "\n Tu sueldo sera de 6.000 brutos.",
                from: new Twilio.Types.PhoneNumber("+14722033797"),
                to: new Twilio.Types.PhoneNumber("+51913083916"));

            Console.WriteLine(message.Body);

            Planilla_ planilla = new Planilla_(
                planillaId,
                dto.Codigo,
                dto.FechaConfiguracion,
                dto.SupervisorId,
                dto.FundoId,
                dto.CultivoID,
                dto.AreadId,
                dto.GrupoId,
                dto.Estado,
                usuarioRegistro,
                fechaRegistro
            );
            await registrarPlanillaRepository.RegistrarPlanilla(planilla);
        }
        public async Task ExistePlanillaPorPlanillaId(Guid planillaId){

            bool existe = await _existeServicio.ExistePlanillaPorId(planillaId);

            if (existe) throw new InvalidOperationException(Message.EXISTE_PLANILLA);
        }

        public async Task EnviarSms()
        {


            TwilioClient.Init(accountSid, authToken);

            var message = await MessageResource.CreateAsync(
                body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
                from: new Twilio.Types.PhoneNumber("+14722033797"),
                to: new Twilio.Types.PhoneNumber("+15558675310"));

            Console.WriteLine(message.Body);

        }
    }
}