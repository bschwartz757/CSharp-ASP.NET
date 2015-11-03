using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowDetailService" in both code and config file together.
[ServiceContract]
public interface IShowDetailService
{
    [OperationContract]
    bool AddShow(Show s, ShowDetail sd);
    [OperationContract]
    bool AddArtist(Artist a);
    [OperationContract]
    List<Artist> GetArtists();
    [OperationContract]
    List<Show> GetShows(int vKey);
    [OperationContract]
    List<ShowDetail> GetDetails(int sKey);
}

[DataContract]
public class Detail
{
    [DataMember]
    public string ArtistName { set; get; }
    [DataMember]
    public string ArtistStartTime { set; get; }
    [DataMember]
    public string Additional { set; get; }
}