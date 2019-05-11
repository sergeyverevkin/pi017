using System.Runtime.Serialization;
using System.ServiceModel;

namespace Quiz.Classes.Service
{
  /// <summary>
  /// Сервер, поставляющий картинки
  /// </summary>
  [ServiceContract]
  public interface IPictureServer
  {
    /// <summary>
    /// Получить произвольную картинку с сервера
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    byte[] GetPicture();

    /// <summary>
    /// Получить картинку с именем файла
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    CPicture GetMetaPicture();

    /// <summary>
    /// Получить набор картинок
    /// </summary>
    /// <returns></returns>
    [OperationContract]
    CPictureSet GetPictureSet();
  }

  /// <summary>
  /// картинку с именем файла
  /// </summary>
  [DataContract]
  public class CPictureSet
  {
    /// <summary>
    /// Наименование набора
    /// </summary>
    [DataMember]
    public string Title { get; set; }

    /// <summary>
    /// Картинки
    /// </summary>
    [DataMember]
    public CPicture[] PictureList { get; set; }
  }

  /// <summary>
  /// картинку с именем файла
  /// </summary>
  [DataContract]
  public class CPicture
  {
    /// <summary>
    /// Содержимое файла
    /// </summary>
    [DataMember]
    public byte[] Content;
    /// <summary>
    /// Имя файла
    /// </summary>
    [DataMember]
    public string FileName;
  }
}
