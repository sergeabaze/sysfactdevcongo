using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FACTURATION_DAL;
using FACTURATION_DAL.Model ;
using System.Data;
using System.Configuration;
using System.IO;

namespace TesteApplication
{
    class Program
    {
       static  string getArray(byte[] tab)
        {
            int bufferSize = 10000;

            byte[] buffer = new byte[bufferSize];

            long returnval;

            long startIndex = 0;
           
            buffer = tab;
            MemoryStream stream = new MemoryStream(buffer);
           // stream.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));
            string val = System.Text.Encoding.Default.GetString(tab);
            return val ;
        }
        static void Main(string[] args)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["mysqlReport"].ConnectionString;
               IFacturation dal = new Facturation(connectionString);

                //CompteGeneral compte = new CompteGeneral(connectionString);
                //CompteGeneral de = new CompteGeneral { IdCompteGen=0, Numerocompte="AB1205606320" };
                // compte.Insert(de,20001);
               // CompteGeneral l = compte.SelectByid(2);
               // l.Numerocompte = "cc85213";
               // compte.Update(l);
                //var cp = compte.SelectAll(20001);

               // dal.PARAMETRES_ADD("teste","ras",DateTime .Now );
               //var ret= dal.PARAMETRES_SELECTBYMODE("teste");
               // CompteAnalytique anal = new CompteAnalytique(connectionString);
              //  CompteAnalytique ana = new CompteAnalytique { IdCompteAnalytique = 0, Numerocompte = "anal20140022" };
              //  CompteAnalytique ana = anal.SelectByid(3);
              //  ana.Numerocompte = "analy852136";
               // anal.Update(ana);
               // anal.Insert(ana,20001);
               // var dana = anal.SelectAll(20001);
               // CompteAnalClient cmpteCli = new CompteAnalClient(connectionString);
               // CompteAnalClient cac = new CompteAnalClient { Id = 0, IdClient = 510001, IdCompteAnal = 1};
              // cmpteCli.Insert(cac);
               // CompteAnalClient cmpteCliu = new CompteAnalClient(510001, connectionString);
                //var cp = cmpteCli.CompteAnalyTiques;//cmpteCli.SelectByClientid(510001);
               string del="machin";
              //  string val = "serge pc";
              //  byte[] buffer = Encoding.ASCII.GetBytes(val);
              //  string decodage = System.Text.Encoding.Default.GetString(buffer);
              //// dal.Computer_Connect_ADD(buffer, "blaise");

              //  var  liste = dal.GetListeVues();
              //  DataTable tableComputer = dal.Computer_connect_select();
              //  int i = 0;
              //  foreach (DataRow row in tableComputer.Rows)
              //      Console.WriteLine(" host name:{0}  - user name: {1}", getArray((byte[])row[0]), row[1]);
                 
                
               // Console.WriteLine(" host name:{0}  - user name: {1}", System.Text.Encoding.Default.GetString((byte[])row[0]), row[1]);

                
                
                
                // List <Utilisateur> liste= dal.GetAllUtilisateur();
                // Utilisateur user = dal.GetUtilisateurLoggin("sa", "sa");
                //liste[0].Prenom = "fils serge Romuald";
                //Utilisateur user = new Utilisateur { IdUtilisateur =0, Nom ="Engolo", Prenom ="parfait", Fonction ="comptable", Loggin ="compta", Password ="compta" };

               // bool value = dal.Utilisateur_LogName("SergE");
               // Utilisateur user=dal .GetUtilisateurLoggin_New ("serge","serge","desi");
                //Utilisateur nuser = dal.GetUtilisateurLoggin("serge","desi");
               // string mop = "de";

                //dal.UTILISATEURADD(user);
                //Client cli = dal.GetALL_CLIENTByID(0);
                //cli.IdClient = 0;
                //cli.IdLangue = 2;
                //cli.BoitePostal = "25";
                //cli.TermeNombre  = "30";
                //cli.TermeDescription  ="days at invoice";
                //dal.CLIENT_ADD(cli);
                // dal.CLIENT_DELETE(3);

                //List<ObjetFacture> lt = dal.GetAll_OBJET_FACTURE();
                //ObjetFacture ff = new ObjetFacture { IdObjet =0, Libelle ="mangerddd le rit", IdLangue =1 };
                // ObjetFacture f = dal.GetAll_OBJET_FACTUREBYID(1);
                //f.IdLangue = 2;
                //dal.OBJET_FACTURE_ADD(ff);
                // List<ObjetFacture> fe = dal.GetAll_OBJET_FACTUREBYLangue(1);
                // List<ObjetFacture> fes = dal.GetAll_OBJET_FACTURE ();

                // List<ExploitationFacture> lst = dal.GetAll_EXPLOITATION_FACTURE();
                // List<ExploitationFacture> lst = dal.GetAll_EXPLOITATION_FACTUREBYLangue (1);
                // ExploitationFacture ff = new ExploitationFacture {  IdExploitation  = 0, Libelle = "my explotataion 5", IdLangue = 2 };
                // dal.EXPLOITATION_FACTURE_ADD(ff);
                // dal.EXPLOITATION_FACTURE_DELETE(3);
                //Societe so = dal.Get_SOCIETE();
                // Societe ss = new Societe { IdSociete =0, RaisonSocial ="sodexo cameroun", NomManager ="Elimba manege", TitreManager ="directeur generea", NumContribualbe ="M0770000", NumImmatriculation ="tva-230", Adesse_1 ="rue akawa delote" };

                //so.Adesse_1 = "9 rue nobra akwa";
                //so.BoitePostal = "212";
                //so.Ville = "douala";
                //dal.SOCIETE_ADD(ss);
                // dal.SOCIETE_DELETE();
                //DataTable table = dal.ReportLIBELLE(1);
                // List<ModePaiement> mode = dal.GetAll_MODE_PAIEMENT();
                //ModePaiement mode = new ModePaiement { IdMode=0, Libelle ="Cheque", IdLangue =1 };
                //dal.MODE_PAIEMENT_ADD(mode);

                //  List<Produit> p = dal.GetAll_PRODUIT();
                // List<Produit> p = dal.GetAll_PRODUIT_BYLangue (2); 
                // ProduitDetail dtl = new ProduitDetail { IdDetail =0, IdClient =1, IdProduit =3, PrixUnitaire =100, Quantite =10, Exonerer =true   };
                //dal.PRODUIT_DETAIL_ADD(dtl);
                // List<ProduitDetail> dt = dal.GetAll_DETAIL_PRODUITBY_PRODUIT(3, 0);

               //List<StatutFacture> st = dal.GetAll_STATUT_FACTURE();

               // StatutFacture sts = new StatutFacture { IdStatut=0, Libelle ="Suspendu", IdLangue =1 };
               //// dal.STATUT_FACTURE_ADD(sts);
               //List<Facture> ff = dal.GetAll_FACTURE();
               // Facture f = new Facture
               // {
               //     IdFacture = 0,
               //     IdCreerpar = 1,
               //     IdObjetFacture = 1,
               //     Idexploitation = 1,
               //     IdModePaiement = 1,
               //     IdTaxe = 1, IdStatut =1, IdClient =2,
               //     MoisPrestation = DateTime.Parse("12/05/2010")
               // };
              // dal.FACTURE_ADD(f);

                //List<LigneFacture> lgn = dal.GetAll_LIGNE_FACTURE(1);

                //LigneFacture ll = new LigneFacture { IdLigneFacture =0, IdFacture =1, IdUtilisateur=1, IdProduit=1, Exonere =false , Description ="nes decription", Quantite =10 };
                //dal.LIGNE_FACTURE_ADD(ll);
              // JournalVentesDates jv = new JournalVentesDates { ID=0, DateDebut =DateTime.Parse ("01/01/2013 10:20:02"), DateFin=DateTime .Parse ("31/05/2013 20:20:45"), IdSite=20001 };
              // int id = 0;
              // dal.JournalVenteDatesADD(ref id,jv);

              // DataTable t = dal.GetJournalVentesDates_Periodes(20001);
               //var jnl = dal.GetJournalVentesDates_List(20001, DateTime.Parse("01/01/2014 10:20:02"));
            int nbre=0;
          //  bool ops = dal.GenerationJournalVentesGlobal(ref nbre, 20001, DateTime.Parse("01/11/2013"), DateTime.Parse("30/11/2013"));
           // var liste = dal.GetJournalVente_Historique(6);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de traitement ------ {0}",ex .Message );
            }
            
            Console.ReadKey();


        }
    }
}
