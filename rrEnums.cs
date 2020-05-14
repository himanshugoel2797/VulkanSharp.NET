namespace RadeonRaysSharp.Raw {
	public unsafe static partial class RadeonRays {
#pragma warning disable CA1712 // Do not prefix enum values with type name
		public enum RRError {
			RrSuccess = 0,
			RrErrorNotImplemented = 1,
			RrErrorInternal = 2,
			RrErrorOutOfHostMemory = 3,
			RrErrorOutOfDeviceMemory = 4,
			RrErrorInvalidApiVersion = 5,
			RrErrorInvalidParameter = 6,
			RrErrorUnsupportedApi = 7,
			RrErrorUnsupportedInterop = 8,
		}
		public enum RRApi {
			RrApiDx = 1,
			RrApi = 2,
			RrApiMtl = 3,
		}
		public enum RRBuildOperation {
			RrBuildOperationBuild = 1,
			RrBuildOperationUpdate = 2,
		}
		public enum RRBuildFlags {
			RrBuildFlagBitsPreferFastBuild = 1,
			RrBuildFlagBitsAllowUpdate = 2,
		}
		public enum RRPrimitiveType {
			RrPrimitiveTypeTriangleMesh = 0,
			RrPrimitiveTypeAabbList = 1,
		}
		public enum RRIndexType {
			RrIndexTypeUint32 = 0,
			RrIndexTypeUint16 = 1,
		}
		public enum RRIntersectQuery {
			RrIntersectQueryClosest = 0,
			RrIntersectQueryAny = 1,
		}
		public enum RRIntersectQueryOutput {
			RrIntersectQueryOutputFullHit = 0,
			RrIntersectQueryOutputInstanceId = 1,
		}
	}
}
