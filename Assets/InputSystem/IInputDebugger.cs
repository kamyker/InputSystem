using ISX.LowLevel;

#if UNITY_EDITOR
namespace ISX
{
    // Internal interface that allows monitoring the system for problems.
    // This is primarily meant to make it easier to diagnose problems in the event stream.
    internal interface IInputDebugger
    {
        void OnCannotFindDeviceForEvent(InputEventPtr eventPtr);
        void OnEventTimestampOutdated(InputEventPtr eventPtr, InputDevice device);
        void OnEventFormatMismatch(InputEventPtr eventPtr, InputDevice device);
    }
}
#endif