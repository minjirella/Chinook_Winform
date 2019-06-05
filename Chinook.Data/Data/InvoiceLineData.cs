using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class InvoiceLineData : EntityData<InvoiceLine>
    {
        public List<InvoiceLine> GetByInvoiceId(int invoiceId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                var query = from x in context.InvoiceLines
                            select new
                            {
                                TrackName = x.Track.Name,
                                ArtistName = x.Track.Album.Artist.Name,
                                InvoiceLine = x
                            };

                query = query.Where(x => x.InvoiceLine.InvoiceLineId == invoiceId);

                var list = query.ToList();

                foreach (var x in list)
                {
                    //x.Invoice.CustomerName = x.CustomerName;
                    x.InvoiceLine.TrackName = x.TrackName;
                    x.InvoiceLine.ArtistName = x.ArtistName;
                }

                return list.ConvertAll(x => x.InvoiceLine);
            }
        }
    }
}
