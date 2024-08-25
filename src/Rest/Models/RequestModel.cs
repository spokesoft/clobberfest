namespace Spokesoft.Clobberfest.Rest.Models
{
    /// <summary>
    /// Request model interface for all RESTful API requests.
    /// </summary>
    public interface IRequestModel
    {

    }

    /// <summary>
    /// Find a model
    /// </summary>
    public interface IFindRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Find a collection of models
    /// </summary>
    public interface IFindRangeRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Create a model
    /// </summary>
    public interface ICreateRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Create a collection of models
    /// </summary>
    public interface ICreateRangeRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Update a model
    /// </summary>
    public interface IUpdateRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Update a range of models
    /// </summary>
    public interface IUpdateRangeRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Delete a model
    /// </summary>
    public interface IDeleteRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Delete a range of models
    /// </summary>
    public interface IDeleteRangeRequestModel : IRequestModel
    {

    }

    /// <summary>
    /// Base request model
    /// </summary>
    public abstract class BaseRequestModel : IRequestModel {}
    public abstract class BaseFindRequestModel : BaseRequestModel, IFindRequestModel {}
    public abstract class BaseBaseFindRangeRequestModel : BaseRequestModel, IFindRangeRequestModel {}
    public abstract class BaseCreateRequestModel : BaseRequestModel, ICreateRequestModel {}
    public abstract class BaseCreateRangeRequestModel : BaseRequestModel, ICreateRangeRequestModel {}
    public abstract class BaseUpdateRequestModel : BaseRequestModel, IUpdateRequestModel {}
    public abstract class BaseUpdateRangeRequestModel : BaseRequestModel, IUpdateRangeRequestModel {}
    public abstract class BaseDeleteRequestModel : BaseRequestModel, IDeleteRequestModel {}
    public abstract class BaseDeleteRangeRequestModel : BaseRequestModel, IDeleteRangeRequestModel {}

    /// <summary>
    /// Request model class
    /// </summary>
    public partial class RequestModel : BaseRequestModel {}
    public partial class FindRequestModel : BaseFindRequestModel {}
    public partial class FindRangeRequestModel : BaseBaseFindRangeRequestModel {}
    public partial class CreateRequestModel : BaseCreateRequestModel {}
    public partial class CreateRangeRequestModel : BaseCreateRangeRequestModel {}
    public partial class UpdateRequestModel : BaseUpdateRequestModel {}
    public partial class UpdateRangeRequestModel : BaseUpdateRangeRequestModel {}
    public partial class DeleteRequestModel : BaseDeleteRequestModel {}
    public partial class DeleteRangeRequestModel : BaseDeleteRangeRequestModel {}
}
