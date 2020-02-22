using System;
using System.Runtime.InteropServices;
using static VulkanSharp.Raw.Vk;
namespace VulkanSharp.Raw {
	public unsafe static partial class Glfw {
		public static int glfwInit() { throw new NotImplementedException(); }
		public static void glfwTerminate() { throw new NotImplementedException(); }
		public static void glfwInitHint(int hint, int value) { throw new NotImplementedException(); }
		public static void glfwGetVersion(int* major, int* minor, int* rev) { throw new NotImplementedException(); }
		public static string glfwGetVersionString() { throw new NotImplementedException(); }
		public static int glfwGetError(IntPtr* description) { throw new NotImplementedException(); }
		public static IntPtr glfwSetErrorCallback(IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr** glfwGetMonitors(int* count) { throw new NotImplementedException(); }
		public static IntPtr* glfwGetPrimaryMonitor() { throw new NotImplementedException(); }
		public static void glfwGetMonitorPos(IntPtr* monitor, int* xpos, int* ypos) { throw new NotImplementedException(); }
		public static void glfwGetMonitorWorkarea(IntPtr* monitor, int* xpos, int* ypos, int* width, int* height) { throw new NotImplementedException(); }
		public static void glfwGetMonitorPhysicalSize(IntPtr* monitor, int* widthMM, int* heightMM) { throw new NotImplementedException(); }
		public static void glfwGetMonitorContentScale(IntPtr* monitor, float* xscale, float* yscale) { throw new NotImplementedException(); }
		public static string glfwGetMonitorName(IntPtr* monitor) { throw new NotImplementedException(); }
		public static void glfwSetMonitorUserPointer(IntPtr* monitor, IntPtr pointer) { throw new NotImplementedException(); }
		public static IntPtr glfwGetMonitorUserPointer(IntPtr* monitor) { throw new NotImplementedException(); }
		public static IntPtr glfwSetMonitorCallback(IntPtr callback) { throw new NotImplementedException(); }
		public static GLFWvidmode* glfwGetVideoModes(IntPtr* monitor, int* count) { throw new NotImplementedException(); }
		public static GLFWvidmode* glfwGetVideoMode(IntPtr* monitor) { throw new NotImplementedException(); }
		public static void glfwSetGamma(IntPtr* monitor, float gamma) { throw new NotImplementedException(); }
		public static GLFWgammaramp* glfwGetGammaRamp(IntPtr* monitor) { throw new NotImplementedException(); }
		public static void glfwSetGammaRamp(IntPtr* monitor, [MarshalAs(UnmanagedType.LPArray)]GLFWgammaramp[] ramp) { throw new NotImplementedException(); }
		public static void glfwDefaultWindowHints() { throw new NotImplementedException(); }
		public static void glfwWindowHint(int hint, int value) { throw new NotImplementedException(); }
		public static void glfwWindowHintString(int hint, string value) { throw new NotImplementedException(); }
		public static IntPtr* glfwCreateWindow(int width, int height, string title, IntPtr* monitor, IntPtr* share) { throw new NotImplementedException(); }
		public static void glfwDestroyWindow(IntPtr* window) { throw new NotImplementedException(); }
		public static int glfwWindowShouldClose(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwSetWindowShouldClose(IntPtr* window, int value) { throw new NotImplementedException(); }
		public static void glfwSetWindowTitle(IntPtr* window, string title) { throw new NotImplementedException(); }
		public static void glfwSetWindowIcon(IntPtr* window, int count, [MarshalAs(UnmanagedType.LPArray)]GLFWimage[] images) { throw new NotImplementedException(); }
		public static void glfwGetWindowPos(IntPtr* window, int* xpos, int* ypos) { throw new NotImplementedException(); }
		public static void glfwSetWindowPos(IntPtr* window, int xpos, int ypos) { throw new NotImplementedException(); }
		public static void glfwGetWindowSize(IntPtr* window, int* width, int* height) { throw new NotImplementedException(); }
		public static void glfwSetWindowSizeLimits(IntPtr* window, int minwidth, int minheight, int maxwidth, int maxheight) { throw new NotImplementedException(); }
		public static void glfwSetWindowAspectRatio(IntPtr* window, int numer, int denom) { throw new NotImplementedException(); }
		public static void glfwSetWindowSize(IntPtr* window, int width, int height) { throw new NotImplementedException(); }
		public static void glfwGetFramebufferSize(IntPtr* window, int* width, int* height) { throw new NotImplementedException(); }
		public static void glfwGetWindowFrameSize(IntPtr* window, int* left, int* top, int* right, int* bottom) { throw new NotImplementedException(); }
		public static void glfwGetWindowContentScale(IntPtr* window, float* xscale, float* yscale) { throw new NotImplementedException(); }
		public static float glfwGetWindowOpacity(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwSetWindowOpacity(IntPtr* window, float opacity) { throw new NotImplementedException(); }
		public static void glfwIconifyWindow(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwRestoreWindow(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwMaximizeWindow(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwShowWindow(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwHideWindow(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwFocusWindow(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwRequestWindowAttention(IntPtr* window) { throw new NotImplementedException(); }
		public static IntPtr* glfwGetWindowMonitor(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwSetWindowMonitor(IntPtr* window, IntPtr* monitor, int xpos, int ypos, int width, int height, int refreshRate) { throw new NotImplementedException(); }
		public static int glfwGetWindowAttrib(IntPtr* window, int attrib) { throw new NotImplementedException(); }
		public static void glfwSetWindowAttrib(IntPtr* window, int attrib, int value) { throw new NotImplementedException(); }
		public static void glfwSetWindowUserPointer(IntPtr* window, IntPtr pointer) { throw new NotImplementedException(); }
		public static IntPtr glfwGetWindowUserPointer(IntPtr* window) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowPosCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowSizeCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowCloseCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowRefreshCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowFocusCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowIconifyCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowMaximizeCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetFramebufferSizeCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetWindowContentScaleCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static void glfwPollEvents() { throw new NotImplementedException(); }
		public static void glfwWaitEvents() { throw new NotImplementedException(); }
		public static void glfwWaitEventsTimeout(double timeout) { throw new NotImplementedException(); }
		public static void glfwPostEmptyEvent() { throw new NotImplementedException(); }
		public static int glfwGetInputMode(IntPtr* window, int mode) { throw new NotImplementedException(); }
		public static void glfwSetInputMode(IntPtr* window, int mode, int value) { throw new NotImplementedException(); }
		public static int glfwRawMouseMotionSupported() { throw new NotImplementedException(); }
		public static string glfwGetKeyName(int key, int scancode) { throw new NotImplementedException(); }
		public static int glfwGetKeyScancode(int key) { throw new NotImplementedException(); }
		public static int glfwGetKey(IntPtr* window, int key) { throw new NotImplementedException(); }
		public static int glfwGetMouseButton(IntPtr* window, int button) { throw new NotImplementedException(); }
		public static void glfwGetCursorPos(IntPtr* window, double* xpos, double* ypos) { throw new NotImplementedException(); }
		public static void glfwSetCursorPos(IntPtr* window, double xpos, double ypos) { throw new NotImplementedException(); }
		public static IntPtr* glfwCreateCursor([MarshalAs(UnmanagedType.LPArray)]GLFWimage[] image, int xhot, int yhot) { throw new NotImplementedException(); }
		public static IntPtr* glfwCreateStandardCursor(int shape) { throw new NotImplementedException(); }
		public static void glfwDestroyCursor(IntPtr* cursor) { throw new NotImplementedException(); }
		public static void glfwSetCursor(IntPtr* window, IntPtr* cursor) { throw new NotImplementedException(); }
		public static IntPtr glfwSetKeyCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetCharCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetCharModsCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetMouseButtonCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetCursorPosCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetCursorEnterCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetScrollCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static IntPtr glfwSetDropCallback(IntPtr* window, IntPtr callback) { throw new NotImplementedException(); }
		public static int glfwJoystickPresent(int jid) { throw new NotImplementedException(); }
		public static float* glfwGetJoystickAxes(int jid, int* count) { throw new NotImplementedException(); }
		public static byte* glfwGetJoystickButtons(int jid, int* count) { throw new NotImplementedException(); }
		public static byte* glfwGetJoystickHats(int jid, int* count) { throw new NotImplementedException(); }
		public static string glfwGetJoystickName(int jid) { throw new NotImplementedException(); }
		public static string glfwGetJoystickGUID(int jid) { throw new NotImplementedException(); }
		public static void glfwSetJoystickUserPointer(int jid, IntPtr pointer) { throw new NotImplementedException(); }
		public static IntPtr glfwGetJoystickUserPointer(int jid) { throw new NotImplementedException(); }
		public static int glfwJoystickIsGamepad(int jid) { throw new NotImplementedException(); }
		public static IntPtr glfwSetJoystickCallback(IntPtr callback) { throw new NotImplementedException(); }
		public static int glfwUpdateGamepadMappings(string @string) { throw new NotImplementedException(); }
		public static string glfwGetGamepadName(int jid) { throw new NotImplementedException(); }
		public static int glfwGetGamepadState(int jid, [MarshalAs(UnmanagedType.LPArray)]GLFWgamepadstate[] state) { throw new NotImplementedException(); }
		public static void glfwSetClipboardString(IntPtr* window, string @string) { throw new NotImplementedException(); }
		public static string glfwGetClipboardString(IntPtr* window) { throw new NotImplementedException(); }
		public static double glfwGetTime() { throw new NotImplementedException(); }
		public static void glfwSetTime(double time) { throw new NotImplementedException(); }
		public static ulong glfwGetTimerValue() { throw new NotImplementedException(); }
		public static ulong glfwGetTimerFrequency() { throw new NotImplementedException(); }
		public static void glfwMakeContextCurrent(IntPtr* window) { throw new NotImplementedException(); }
		public static IntPtr* glfwGetCurrentContext() { throw new NotImplementedException(); }
		public static void glfwSwapBuffers(IntPtr* window) { throw new NotImplementedException(); }
		public static void glfwSwapInterval(int interval) { throw new NotImplementedException(); }
		public static int glfwExtensionSupported(string extension) { throw new NotImplementedException(); }
		public static IntPtr glfwGetProcAddress(string procname) { throw new NotImplementedException(); }
		public static int glfwVulkanSupported() { throw new NotImplementedException(); }
		public static IntPtr* glfwGetRequiredInstanceExtensions(uint* count) { throw new NotImplementedException(); }
		public static IntPtr glfwGetInstanceProcAddress(IntPtr instance, string procname) { throw new NotImplementedException(); }
		public static int glfwGetPhysicalDevicePresentationSupport(IntPtr instance, IntPtr device, uint queuefamily) { throw new NotImplementedException(); }
		public static VkResult glfwCreateWindowSurface(IntPtr instance, IntPtr* window, IntPtr* allocator, IntPtr* surface) { throw new NotImplementedException(); }
		internal static IntPtr glfwInit_hndl;
		internal static IntPtr glfwTerminate_hndl;
		internal static IntPtr glfwInitHint_hndl;
		internal static IntPtr glfwGetVersion_hndl;
		internal static IntPtr glfwGetVersionString_hndl;
		internal static IntPtr glfwGetError_hndl;
		internal static IntPtr glfwSetErrorCallback_hndl;
		internal static IntPtr glfwGetMonitors_hndl;
		internal static IntPtr glfwGetPrimaryMonitor_hndl;
		internal static IntPtr glfwGetMonitorPos_hndl;
		internal static IntPtr glfwGetMonitorWorkarea_hndl;
		internal static IntPtr glfwGetMonitorPhysicalSize_hndl;
		internal static IntPtr glfwGetMonitorContentScale_hndl;
		internal static IntPtr glfwGetMonitorName_hndl;
		internal static IntPtr glfwSetMonitorUserPointer_hndl;
		internal static IntPtr glfwGetMonitorUserPointer_hndl;
		internal static IntPtr glfwSetMonitorCallback_hndl;
		internal static IntPtr glfwGetVideoModes_hndl;
		internal static IntPtr glfwGetVideoMode_hndl;
		internal static IntPtr glfwSetGamma_hndl;
		internal static IntPtr glfwGetGammaRamp_hndl;
		internal static IntPtr glfwSetGammaRamp_hndl;
		internal static IntPtr glfwDefaultWindowHints_hndl;
		internal static IntPtr glfwWindowHint_hndl;
		internal static IntPtr glfwWindowHintString_hndl;
		internal static IntPtr glfwCreateWindow_hndl;
		internal static IntPtr glfwDestroyWindow_hndl;
		internal static IntPtr glfwWindowShouldClose_hndl;
		internal static IntPtr glfwSetWindowShouldClose_hndl;
		internal static IntPtr glfwSetWindowTitle_hndl;
		internal static IntPtr glfwSetWindowIcon_hndl;
		internal static IntPtr glfwGetWindowPos_hndl;
		internal static IntPtr glfwSetWindowPos_hndl;
		internal static IntPtr glfwGetWindowSize_hndl;
		internal static IntPtr glfwSetWindowSizeLimits_hndl;
		internal static IntPtr glfwSetWindowAspectRatio_hndl;
		internal static IntPtr glfwSetWindowSize_hndl;
		internal static IntPtr glfwGetFramebufferSize_hndl;
		internal static IntPtr glfwGetWindowFrameSize_hndl;
		internal static IntPtr glfwGetWindowContentScale_hndl;
		internal static IntPtr glfwGetWindowOpacity_hndl;
		internal static IntPtr glfwSetWindowOpacity_hndl;
		internal static IntPtr glfwIconifyWindow_hndl;
		internal static IntPtr glfwRestoreWindow_hndl;
		internal static IntPtr glfwMaximizeWindow_hndl;
		internal static IntPtr glfwShowWindow_hndl;
		internal static IntPtr glfwHideWindow_hndl;
		internal static IntPtr glfwFocusWindow_hndl;
		internal static IntPtr glfwRequestWindowAttention_hndl;
		internal static IntPtr glfwGetWindowMonitor_hndl;
		internal static IntPtr glfwSetWindowMonitor_hndl;
		internal static IntPtr glfwGetWindowAttrib_hndl;
		internal static IntPtr glfwSetWindowAttrib_hndl;
		internal static IntPtr glfwSetWindowUserPointer_hndl;
		internal static IntPtr glfwGetWindowUserPointer_hndl;
		internal static IntPtr glfwSetWindowPosCallback_hndl;
		internal static IntPtr glfwSetWindowSizeCallback_hndl;
		internal static IntPtr glfwSetWindowCloseCallback_hndl;
		internal static IntPtr glfwSetWindowRefreshCallback_hndl;
		internal static IntPtr glfwSetWindowFocusCallback_hndl;
		internal static IntPtr glfwSetWindowIconifyCallback_hndl;
		internal static IntPtr glfwSetWindowMaximizeCallback_hndl;
		internal static IntPtr glfwSetFramebufferSizeCallback_hndl;
		internal static IntPtr glfwSetWindowContentScaleCallback_hndl;
		internal static IntPtr glfwPollEvents_hndl;
		internal static IntPtr glfwWaitEvents_hndl;
		internal static IntPtr glfwWaitEventsTimeout_hndl;
		internal static IntPtr glfwPostEmptyEvent_hndl;
		internal static IntPtr glfwGetInputMode_hndl;
		internal static IntPtr glfwSetInputMode_hndl;
		internal static IntPtr glfwRawMouseMotionSupported_hndl;
		internal static IntPtr glfwGetKeyName_hndl;
		internal static IntPtr glfwGetKeyScancode_hndl;
		internal static IntPtr glfwGetKey_hndl;
		internal static IntPtr glfwGetMouseButton_hndl;
		internal static IntPtr glfwGetCursorPos_hndl;
		internal static IntPtr glfwSetCursorPos_hndl;
		internal static IntPtr glfwCreateCursor_hndl;
		internal static IntPtr glfwCreateStandardCursor_hndl;
		internal static IntPtr glfwDestroyCursor_hndl;
		internal static IntPtr glfwSetCursor_hndl;
		internal static IntPtr glfwSetKeyCallback_hndl;
		internal static IntPtr glfwSetCharCallback_hndl;
		internal static IntPtr glfwSetCharModsCallback_hndl;
		internal static IntPtr glfwSetMouseButtonCallback_hndl;
		internal static IntPtr glfwSetCursorPosCallback_hndl;
		internal static IntPtr glfwSetCursorEnterCallback_hndl;
		internal static IntPtr glfwSetScrollCallback_hndl;
		internal static IntPtr glfwSetDropCallback_hndl;
		internal static IntPtr glfwJoystickPresent_hndl;
		internal static IntPtr glfwGetJoystickAxes_hndl;
		internal static IntPtr glfwGetJoystickButtons_hndl;
		internal static IntPtr glfwGetJoystickHats_hndl;
		internal static IntPtr glfwGetJoystickName_hndl;
		internal static IntPtr glfwGetJoystickGUID_hndl;
		internal static IntPtr glfwSetJoystickUserPointer_hndl;
		internal static IntPtr glfwGetJoystickUserPointer_hndl;
		internal static IntPtr glfwJoystickIsGamepad_hndl;
		internal static IntPtr glfwSetJoystickCallback_hndl;
		internal static IntPtr glfwUpdateGamepadMappings_hndl;
		internal static IntPtr glfwGetGamepadName_hndl;
		internal static IntPtr glfwGetGamepadState_hndl;
		internal static IntPtr glfwSetClipboardString_hndl;
		internal static IntPtr glfwGetClipboardString_hndl;
		internal static IntPtr glfwGetTime_hndl;
		internal static IntPtr glfwSetTime_hndl;
		internal static IntPtr glfwGetTimerValue_hndl;
		internal static IntPtr glfwGetTimerFrequency_hndl;
		internal static IntPtr glfwMakeContextCurrent_hndl;
		internal static IntPtr glfwGetCurrentContext_hndl;
		internal static IntPtr glfwSwapBuffers_hndl;
		internal static IntPtr glfwSwapInterval_hndl;
		internal static IntPtr glfwExtensionSupported_hndl;
		internal static IntPtr glfwGetProcAddress_hndl;
		internal static IntPtr glfwVulkanSupported_hndl;
		internal static IntPtr glfwGetRequiredInstanceExtensions_hndl;
		internal static IntPtr glfwGetInstanceProcAddress_hndl;
		internal static IntPtr glfwGetPhysicalDevicePresentationSupport_hndl;
		internal static IntPtr glfwCreateWindowSurface_hndl;
		private static void InitPtrs() {
			NativeLibrary.TryGetExport(libHndl, "glfwInit", out glfwInit_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwTerminate", out glfwTerminate_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwInitHint", out glfwInitHint_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetVersion", out glfwGetVersion_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetVersionString", out glfwGetVersionString_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetError", out glfwGetError_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetErrorCallback", out glfwSetErrorCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMonitors", out glfwGetMonitors_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetPrimaryMonitor", out glfwGetPrimaryMonitor_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMonitorPos", out glfwGetMonitorPos_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMonitorWorkarea", out glfwGetMonitorWorkarea_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMonitorPhysicalSize", out glfwGetMonitorPhysicalSize_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMonitorContentScale", out glfwGetMonitorContentScale_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMonitorName", out glfwGetMonitorName_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetMonitorUserPointer", out glfwSetMonitorUserPointer_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMonitorUserPointer", out glfwGetMonitorUserPointer_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetMonitorCallback", out glfwSetMonitorCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetVideoModes", out glfwGetVideoModes_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetVideoMode", out glfwGetVideoMode_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetGamma", out glfwSetGamma_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetGammaRamp", out glfwGetGammaRamp_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetGammaRamp", out glfwSetGammaRamp_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwDefaultWindowHints", out glfwDefaultWindowHints_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwWindowHint", out glfwWindowHint_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwWindowHintString", out glfwWindowHintString_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwCreateWindow", out glfwCreateWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwDestroyWindow", out glfwDestroyWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwWindowShouldClose", out glfwWindowShouldClose_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowShouldClose", out glfwSetWindowShouldClose_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowTitle", out glfwSetWindowTitle_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowIcon", out glfwSetWindowIcon_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowPos", out glfwGetWindowPos_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowPos", out glfwSetWindowPos_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowSize", out glfwGetWindowSize_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowSizeLimits", out glfwSetWindowSizeLimits_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowAspectRatio", out glfwSetWindowAspectRatio_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowSize", out glfwSetWindowSize_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetFramebufferSize", out glfwGetFramebufferSize_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowFrameSize", out glfwGetWindowFrameSize_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowContentScale", out glfwGetWindowContentScale_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowOpacity", out glfwGetWindowOpacity_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowOpacity", out glfwSetWindowOpacity_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwIconifyWindow", out glfwIconifyWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwRestoreWindow", out glfwRestoreWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwMaximizeWindow", out glfwMaximizeWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwShowWindow", out glfwShowWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwHideWindow", out glfwHideWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwFocusWindow", out glfwFocusWindow_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwRequestWindowAttention", out glfwRequestWindowAttention_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowMonitor", out glfwGetWindowMonitor_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowMonitor", out glfwSetWindowMonitor_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowAttrib", out glfwGetWindowAttrib_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowAttrib", out glfwSetWindowAttrib_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowUserPointer", out glfwSetWindowUserPointer_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetWindowUserPointer", out glfwGetWindowUserPointer_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowPosCallback", out glfwSetWindowPosCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowSizeCallback", out glfwSetWindowSizeCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowCloseCallback", out glfwSetWindowCloseCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowRefreshCallback", out glfwSetWindowRefreshCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowFocusCallback", out glfwSetWindowFocusCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowIconifyCallback", out glfwSetWindowIconifyCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowMaximizeCallback", out glfwSetWindowMaximizeCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetFramebufferSizeCallback", out glfwSetFramebufferSizeCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetWindowContentScaleCallback", out glfwSetWindowContentScaleCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwPollEvents", out glfwPollEvents_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwWaitEvents", out glfwWaitEvents_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwWaitEventsTimeout", out glfwWaitEventsTimeout_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwPostEmptyEvent", out glfwPostEmptyEvent_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetInputMode", out glfwGetInputMode_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetInputMode", out glfwSetInputMode_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwRawMouseMotionSupported", out glfwRawMouseMotionSupported_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetKeyName", out glfwGetKeyName_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetKeyScancode", out glfwGetKeyScancode_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetKey", out glfwGetKey_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetMouseButton", out glfwGetMouseButton_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetCursorPos", out glfwGetCursorPos_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetCursorPos", out glfwSetCursorPos_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwCreateCursor", out glfwCreateCursor_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwCreateStandardCursor", out glfwCreateStandardCursor_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwDestroyCursor", out glfwDestroyCursor_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetCursor", out glfwSetCursor_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetKeyCallback", out glfwSetKeyCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetCharCallback", out glfwSetCharCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetCharModsCallback", out glfwSetCharModsCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetMouseButtonCallback", out glfwSetMouseButtonCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetCursorPosCallback", out glfwSetCursorPosCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetCursorEnterCallback", out glfwSetCursorEnterCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetScrollCallback", out glfwSetScrollCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetDropCallback", out glfwSetDropCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwJoystickPresent", out glfwJoystickPresent_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetJoystickAxes", out glfwGetJoystickAxes_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetJoystickButtons", out glfwGetJoystickButtons_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetJoystickHats", out glfwGetJoystickHats_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetJoystickName", out glfwGetJoystickName_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetJoystickGUID", out glfwGetJoystickGUID_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetJoystickUserPointer", out glfwSetJoystickUserPointer_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetJoystickUserPointer", out glfwGetJoystickUserPointer_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwJoystickIsGamepad", out glfwJoystickIsGamepad_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetJoystickCallback", out glfwSetJoystickCallback_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwUpdateGamepadMappings", out glfwUpdateGamepadMappings_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetGamepadName", out glfwGetGamepadName_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetGamepadState", out glfwGetGamepadState_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetClipboardString", out glfwSetClipboardString_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetClipboardString", out glfwGetClipboardString_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetTime", out glfwGetTime_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSetTime", out glfwSetTime_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetTimerValue", out glfwGetTimerValue_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetTimerFrequency", out glfwGetTimerFrequency_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwMakeContextCurrent", out glfwMakeContextCurrent_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetCurrentContext", out glfwGetCurrentContext_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSwapBuffers", out glfwSwapBuffers_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwSwapInterval", out glfwSwapInterval_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwExtensionSupported", out glfwExtensionSupported_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetProcAddress", out glfwGetProcAddress_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwVulkanSupported", out glfwVulkanSupported_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetRequiredInstanceExtensions", out glfwGetRequiredInstanceExtensions_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetInstanceProcAddress", out glfwGetInstanceProcAddress_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwGetPhysicalDevicePresentationSupport", out glfwGetPhysicalDevicePresentationSupport_hndl);
			NativeLibrary.TryGetExport(libHndl, "glfwCreateWindowSurface", out glfwCreateWindowSurface_hndl);
		}
	}
}
