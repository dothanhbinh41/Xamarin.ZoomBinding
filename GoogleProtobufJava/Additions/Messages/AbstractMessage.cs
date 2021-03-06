﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace Com.Google.Protobuf
{
    public sealed partial class Descriptors
    {
        public sealed partial class FieldDescriptor : global::Java.Lang.Object, global::Java.Lang.IComparable
        {
            public int CompareTo(Java.Lang.Object o)
            {
                return CompareTo((FileDescriptor)o);
            }
        }
    }
}