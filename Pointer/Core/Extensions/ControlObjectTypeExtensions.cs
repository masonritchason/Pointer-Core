using Pointer.Core.Enums;

namespace Pointer.Core.Extensions;

public static class ControlObjectTypeExtensions
{
    /// <summary>
    /// Returns all ControlObjectType values as a string enumerable.
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        return
        [
            ToString(ControlObjectType.Document),
            ToString(ControlObjectType.SampleDocument),
            ToString(ControlObjectType.TemplateDocument),
            ToString(ControlObjectType.GenericSample),
            ToString(ControlObjectType.None)
        ];
    }

    /// <summary>
    /// Converts a ControlObjectType value to an equivalent string value.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string ToString(ControlObjectType value)
    {
        if (value == ControlObjectType.Document)
        {
            return "Document";
        }
        if (value == ControlObjectType.SampleDocument)
        {
            return "Sample Document";
        }
        if (value == ControlObjectType.TemplateDocument)
        {
            return "Template Document";
        }
        if (value == ControlObjectType.GenericSample)
        {
            return "Generic Sample";
        }
        else
        {
            return "None";
        }
    }

    /// <summary>
    /// Converts a string value to a ControlObjectType enum value.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static ControlObjectType FromString(string? value)
    {
        if (value is null)
        {
            return ControlObjectType.None;
        }
        if (value.ToLower().Equals("document"))
        {
            return ControlObjectType.Document;
        }
        if (value.Replace(" ", "").ToLower().Equals("sampledocument"))
        {
            return ControlObjectType.SampleDocument;
        }
        if (value.Replace(" ", "").ToLower().Equals("templatedocument"))
        {
            return ControlObjectType.TemplateDocument;
        }
        if (value.Replace(" ", "").ToLower().Equals("genericsample"))
        {
            return ControlObjectType.GenericSample;
        }
        else
        {
            return ControlObjectType.None;
        }
    }
}