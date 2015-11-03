using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShowDetailService" in code, svc and config file together.
public class ShowDetailService : IShowDetailService
{
    ShowTrackerEntities showTrackerDb = new ShowTrackerEntities();

    //Check to see if the artist exists, and if not, add an entry and their information
    public bool AddArtist(Artist a)
    {
        bool result = true;
        try
        {
            Artist artist = new Artist();
            artist.ArtistName = a.ArtistName;
            artist.ArtistEmail = a.ArtistEmail;
            artist.ArtistWebPage = a.ArtistWebPage;
            artist.ArtistDateEntered = DateTime.Now;
            showTrackerDb.Artists.Add(artist);
            showTrackerDb.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }
    //Add the show and show details:
    public bool AddShow(Show s, ShowDetail sd)
    {
       // Use these for test client; must already exist in db: 
       // s.VenueKey = 4;
       // sd.Artist = 6;
        bool result = true;
       try
        {
           
            Show show = new Show();
            show.ShowName = s.ShowName;
            show.ShowDate = s.ShowDate;
            show.ShowDateEntered = DateTime.Now;
            show.VenueKey = s.VenueKey;
            show.ShowTime = s.ShowTime;
            show.ShowTicketInfo = s.ShowTicketInfo;
            showTrackerDb.Shows.Add(show);

            ShowDetail showDetail = new ShowDetail();
            showDetail.ArtistKey = sd.ArtistKey;
            showDetail.Show = show;
            showDetail.ShowDetailAdditional = sd.ShowDetailAdditional;
            showDetail.ShowDetailArtistStartTime = sd.ShowDetailArtistStartTime;
            showTrackerDb.ShowDetails.Add(showDetail);

            showTrackerDb.SaveChanges();
  
        }
        catch
        {
            result = false;
        }
        return result;

    }

    public List<Artist> GetArtists()
    {
        List<Artist> artists = new List<Artist>();

        var art = from a in showTrackerDb.Artists
                  select new {a.ArtistKey, a.ArtistName};

        foreach (var ar in art)
        {
            Artist a = new Artist();
            a.ArtistKey = ar.ArtistKey;
            a.ArtistName = ar.ArtistName;
            artists.Add(a);
        }
        return artists;
        }

        public List<Show> GetShows(int vKey)
    {
        List<Show> shows = new List<Show>();

        var shw = from s in showTrackerDb.Shows
                  where s.VenueKey == vKey
                  select new {s.ShowKey, s.ShowName, s.ShowDate,s.ShowTime, s.ShowTicketInfo };

        foreach (var sh in shw)
        {
            Show s = new Show();
            s.ShowKey = sh.ShowKey;
            s.ShowName = sh.ShowName;
            s.ShowDate = sh.ShowDate;
            s.ShowTime = sh.ShowTime;
            s.ShowTicketInfo = sh.ShowTicketInfo;
            shows.Add(s);
        }

        return shows;
    }

    public List<ShowDetail> GetDetails(int sKey)
    {
        List<ShowDetail> details = new List<ShowDetail>();

        var det = from d in showTrackerDb.ShowDetails
                  where d.ShowKey == sKey
                  select new { d.ShowDetailArtistStartTime, d.ShowDetailAdditional,d.Artist.ArtistName };

        foreach (var sd in det)
        {
            ShowDetail showDetail = new ShowDetail();
            showDetail.ShowDetailArtistStartTime = sd.ShowDetailArtistStartTime;
            showDetail.ShowDetailAdditional = sd.ShowDetailAdditional;
            showDetail.Artist.ArtistName = sd.ArtistName;
            details.Add(showDetail);
        }

        return details;
    }
}

