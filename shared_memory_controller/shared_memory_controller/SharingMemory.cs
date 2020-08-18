using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Shared memory required
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace shared_memory_controller {
    class SharingMemory {

        private static MemoryMappedFile mmf;
        private static MemoryMappedViewAccessor accessor;

        public static bool ConnectMappedMemory() {
            mmf = MemoryMappedFile.OpenExisting("BallBeamSharedMemory");
            if (mmf != null) {
                accessor = mmf.CreateViewAccessor(0, 4 * sizeof(float));
                return true;
            }
            return false;
        }

        public static float getDelta() {
            float value;
            accessor.Read(0, out value);
            return value;
        }

        public static float getPos() {
            float value;
            accessor.Read(sizeof(float), out value);
            return value;
        }

        public static float getAngle() {
            float value;
            accessor.Read(2 * sizeof(float), out value);
            return value;
        }

        public static void setAngle(float angle) {
            accessor.Write(3 * sizeof(float), ref angle);
        }
    }
}
