using Challenger.DB.Repository.british;
using Challenger.Domain.DB.british;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Challenger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<british_chart> _charts;
        static List<british_chart_test> _listTest;
        static List<british_notice> _listNotices;
        static List<british_notice_test> _listTestNotices;

        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void Test()
        {
            using (BritishPaper context = new BritishPaper())
            {
                //context.Database.Log = Log;

                //british_chart_Repository bcr = new british_chart_Repository(context);
                british_notice_Repository bnr = new british_notice_Repository(context);

                _listNotices = bnr.GetAllFull().ToList();
                //List<british_chart> _listNotices = bnr.GetAllFull().ToList();

                _listNotices = _listNotices.Select(x => new british_notice()
                {
                    active = x.active,
                    area_id = x.area_id,
                    cancel_date = x.cancel_date,
                    chart_id = x.chart_id,
                    id = x.id,
                    number = x.number,
                    type = x.type,
                    week_notice_id = x.week_notice_id,
                    british_chart = x.british_chart,
                    data = x.data,
                    british_notice_graphic = x.british_notice_graphic,
                    british_notice_type = x.british_notice_type,
                    british_week_notice = x.british_week_notice,
                    geographical_area = x.geographical_area,
                    vessel_british_notice = x.vessel_british_notice
                }).ToList();


               /*  List<british_chart> charts = bcr.GetAllFull().ToList();

                 _charts = charts.Select(c => {
                     var obj = new british_chart()
                     {
                         british_notice = c.british_notice,
                         cancel_date = c.cancel_date,
                         chart_panel = c.chart_panel,
                         coordinates = c.coordinates,
                         east_limit = c.east_limit,
                         folio = c.folio,
                         id = c.id,
                         international_number = c.international_number,
                         last_notice_id = c.last_notice_id,
                         new_edition_date = c.new_edition_date,
                         next_edition_date = c.next_edition_date,
                         north_limit = c.north_limit,
                         number = c.number,
                         prefix = c.prefix,
                         publication_date = c.publication_date,
                         replaced_by = c.replaced_by,
                         scale = c.scale,
                         south_limit = c.south_limit,
                         status = c.status,
                         status_date = c.status_date,
                         suffix = c.suffix,
                         title = c.title,
                         vessel_british_chart = c.vessel_british_chart,
                         west_limit = c.west_limit
                     };
                     return obj;
                 }).ToList();
                 */
                //var charts = bcr.GetAll();
                //var notices = bnr.GetAll();
                //charts = bcr.GetAllFull();

                int i = 0;
            }
        }

        private void Log(string obj)
        {
            using (var stream = File.AppendText(@".\log.log"))
            {
                stream.WriteLine(obj);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void button_Click2(object sender, RoutedEventArgs e)
        {
            /*string title = _charts.ElementAt(0).title;
            int uni = System.Text.ASCIIEncoding.Unicode.GetByteCount(title);
            int ascii = System.Text.ASCIIEncoding.ASCII.GetByteCount(title);*/
            var rnd = new Random();
            MessageBox.Show($"{_listNotices?.ElementAt(rnd.Next(0, _listNotices.Count))?.number}");
            var g = _listNotices[0].british_notice_graphic;
        }

        private void Clear()
        {
            GC.Collect();
            //MessageBox.Show("Collected");
        }

        private void button_Click3(object sender, RoutedEventArgs e)
        {
            Test();
        }
    }
}
