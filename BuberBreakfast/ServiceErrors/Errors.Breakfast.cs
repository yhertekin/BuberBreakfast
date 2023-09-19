using ErrorOr;
public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: "Breakfast description must be at least 3 characters long and at most 50 characters long"
        );
        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: "Breakfast name must be at least 50 characters long and at most 150 characters long"
        );
        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found"
        );

    }
}