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

namespace US.Zoom.Androidlib.Widget.Adapter
{ 
	public partial class ZmSingleChoiceAdapter : global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter
	{
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
			return OnExCreateViewHolder(parent, viewType);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Adapter.ZmSingleChoiceAdapter.SimpleChoiceViewHolder)holder, position);
        }
    }
}
namespace US.Zoom.Androidlib.Material
{ 
	public partial class ZMContextMenuListAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter
    {
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }
    }
}