namespace Spokesoft.Clobberfest.Rest.Models
{
    public interface IFormModel
    {

    }

    public interface ICreateFormModel : IFormModel
    {

    }

    public interface IUpdateFormModel : IFormModel
    {

    }

    public interface IDeleteFormModel : IFormModel
    {

    }

    public abstract class BaseFormModel : IFormModel
    {

    }

    public abstract class BaseCreateFormModel : BaseFormModel, ICreateFormModel
    {

    }

    public abstract class BaseUpdateFormModel : BaseFormModel, IUpdateFormModel
    {

    }

    public abstract class BaseDeleteFormModel : BaseFormModel, IDeleteFormModel
    {

    }

    public class FormModel : BaseFormModel
    {

    }

    public class CreateFormModel : BaseCreateFormModel
    {

    }

    public class UpdateFormModel : BaseUpdateFormModel
    {

    }

    public class DeleteFormModel : BaseDeleteFormModel
    {

    }
}
