using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace Com.Zipow.Videobox.View.Adapter
{
    public partial class ZmDataRegionsAdapter : global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::Com.Zipow.Videobox.View.Adapter.ZmDataRegionsAdapter.DataRegionViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }
    public partial class ZMPasswordRuleAdapter : global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::Com.Zipow.Videobox.View.Adapter.ZMPasswordRuleAdapter.ViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }
}

