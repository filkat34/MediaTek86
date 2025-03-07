using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les responsables
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utilisateur a le droit de se connecter en tant que "responsable"
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns>vrai si l'utilisateur a le profil "responsable"</returns>
        public Boolean ControleAuthentification(Admin admin)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable ";
                req += "where login=@login and pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", admin.Login);
                parameters.Add("@pwd", admin.Pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }

        /// <summary>
        /// Récupère et retourne les personnels
        /// </summary>
        /// <returns>liste des personnels</returns>
    public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select personnel.idpersonnel, personnel.nom, personnel.prenom, personnel.tel, ";
                req += "personnel.mail, personnel.idservice, service.nom as service ";
                req += "from personnel join service on (personnel.idservice = service.idservice) ";
                req += "order by personnel.nom, personnel.prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], service);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }

        public List<Absence> GetLesAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select absence.datedebut, absence.datefin, motif.idmotif, motif.libelle, ";
                req += "personnel.idpersonnel, personnel.nom, personnel.prenom, personnel.tel, ";
                req += "personnel.mail, personnel.idservice, service.nom ";
                req += "from personnel join service on (personnel.idservice = service.idservice) ";
                req += "join absence on (personnel.idpersonnel = absence.idpersonnel) ";
                req += "join motif on (absence.idmotif = motif.idmotif) ";
                req += "order by absence.datedebut DESC;";

                //string req = "select absence.datedebut, absence.datefin, motif.idmotif, motif.libelle ";
                //req += "from absence join motif on (absence.idmotif = motif.idmotif) ";
                //req += "order by absence.datedebut;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[9], (string)record[10]);
                            Personnel personnel = new Personnel((int)record[4], (string)record[5], (string)record[6],
                                (string)record[7], (string)record[8], service);
                            Motif motif = new Motif((int)record[2], (string)record[3]);
                            Absence absence = new Absence((DateTime)record[0], (DateTime)record[1], motif, personnel);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

    }
}
