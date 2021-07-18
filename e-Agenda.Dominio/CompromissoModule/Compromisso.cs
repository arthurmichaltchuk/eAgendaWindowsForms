using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.CompromissoModule
{
    public class Compromisso : EntidadeBase, IEquatable<Compromisso>
    {        
        public Compromisso(string assunto, string local, string link, DateTime data,
            TimeSpan horaInicio, TimeSpan horaFim, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            Link = link;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaFim;
            Contato = contato;
        }

        public Compromisso()
        {

        }

        public new int Id { get; set; }
        public string Assunto { get; }
        public string Local { get; }
        public string Link { get; }
        public DateTime Data { get; }
        public TimeSpan HoraInicio { get; }
        public TimeSpan HoraTermino { get; }
        public Contato Contato { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Compromisso);
        }

        public bool Equals(Compromisso other)
        {
            return other != null
                && Id == other.Id
                && Assunto == other.Assunto
                && Local == other.Local
                && Link == other.Link
                && Data == other.Data
                && HoraInicio.Equals(other.HoraInicio)
                && HoraTermino.Equals(other.HoraTermino)
                && EqualityComparer<Contato>.Default.Equals(Contato, other.Contato);
        }

        public override int GetHashCode()
        {
            int hashCode = 691503132;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Assunto);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Local);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Link);
            hashCode = hashCode * -1521134295 + Data.GetHashCode();
            hashCode = hashCode * -1521134295 + HoraInicio.GetHashCode();
            hashCode = hashCode * -1521134295 + HoraTermino.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Contato>.Default.GetHashCode(Contato);
            return hashCode;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Assunto))
                resultadoValidacao = "O campo Assunto é obrigatório";

            if (Data == DateTime.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data é obrigatório";

            if (HoraInicio == TimeSpan.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Hora Início é obrigatório";

            if (HoraTermino == TimeSpan.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Hora Término é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public string Validar(string assunto, DateTime data, string horaInicio, string horaFinal)
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(assunto))
                resultadoValidacao = "O campo Assunto é obrigatório";

            if (data == DateTime.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data é obrigatório";

            if(validarHora(horaInicio))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "Hora inicial invalida!";

            if (horaFimDepoisHoraInicio(horaInicio, horaFinal))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "Hora final maior que a inicial!";

            if (validarHora(horaFinal))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "Hora final invalida!";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        private bool validarHora(string tempo)
        {
            try
            {
                string[] horario = tempo.Split(':');
                int hora = Convert.ToInt32(horario[0]);
                int minuto = Convert.ToInt32(horario[1]);
                if (hora > 23 || minuto > 59)
                    return true;
                return false;
            }
            catch
            {
                return true;
            }
        }

        private bool horaFimDepoisHoraInicio(string inicio, string fim)
        {
            try
            {
                string[] horarioI = inicio.Split(':');
                int horaI = Convert.ToInt32(horarioI[0]);
                int minutoI = Convert.ToInt32(horarioI[1]);

                string[] horarioF = fim.Split(':');
                int horaF = Convert.ToInt32(horarioF[0]);
                int minutoF = Convert.ToInt32(horarioF[1]);

                if (horaF > horaI)
                    return false;
                else if (horaF == horaI)
                {
                    if (minutoF > minutoI)
                        return false;
                    return true;
                }
                else
                    return true;
            }
            catch
            {
                return true;
            }
        }
    }
}
