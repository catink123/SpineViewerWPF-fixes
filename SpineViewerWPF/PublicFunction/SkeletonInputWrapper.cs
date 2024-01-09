using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpineViewerWPF.PublicFunction
{
    class SkeletonInputWrapper
    {
        private string version;
        public string Version { get => version; }

        private object skelInput;

        public SkeletonInputWrapper(string version, Stream stream)
        {
            this.version = version;

            if (version == "4.1.00") skelInput = new Spine4_1_00.SkeletonBinary.SkeletonInput(stream);
            else if (version == "4.0.64") skelInput = new Spine4_0_64.SkeletonBinary.SkeletonInput(stream);
            else if (version == "4.0.31") skelInput = new Spine4_0_31.SkeletonBinary.SkeletonInput(stream);
            else throw new InvalidOperationException("Invalid Spine version.");
        }

        public float ReadFloat()
        {
            if (version == "4.1.00") return ((Spine4_1_00.SkeletonBinary.SkeletonInput)skelInput).ReadFloat();
            if (version == "4.0.64") return ((Spine4_0_64.SkeletonBinary.SkeletonInput)skelInput).ReadFloat();
            if (version == "4.0.31") return ((Spine4_0_31.SkeletonBinary.SkeletonInput)skelInput).ReadFloat();
            throw new InvalidOperationException("Invalid Spine version.");
        }

        public long ReadLong()
        {
            if (version == "4.1.00") return ((Spine4_1_00.SkeletonBinary.SkeletonInput)skelInput).ReadLong();
            if (version == "4.0.64") return ((Spine4_0_64.SkeletonBinary.SkeletonInput)skelInput).ReadLong();
            if (version == "4.0.31") return ((Spine4_0_31.SkeletonBinary.SkeletonInput)skelInput).ReadLong();
            throw new InvalidOperationException("Invalid Spine version.");
        }

        public string ReadString()
        {
            if (version == "4.1.00") return ((Spine4_1_00.SkeletonBinary.SkeletonInput)skelInput).ReadString();
            if (version == "4.0.64") return ((Spine4_0_64.SkeletonBinary.SkeletonInput)skelInput).ReadString();
            if (version == "4.0.31") return ((Spine4_0_31.SkeletonBinary.SkeletonInput)skelInput).ReadString();
            throw new InvalidOperationException("Invalid Spine version.");
        }
    }
}
