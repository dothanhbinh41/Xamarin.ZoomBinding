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

namespace Com.Zipow.Videobox.View.MM
{
    public partial class MMContentFilesAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter, global::Com.Zipow.Videobox.View.MM.MMZoomFileView.IOnShowAllShareActionListener, global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.IPinnedSectionAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }

    public partial class MMContentImagesAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter, global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.IPinnedSectionAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }

    public partial class MMChatsListAdapter : global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::Com.Zipow.Videobox.View.MM.MMChatsListAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }
    public partial class ReactionEmojiDetailListAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }

}

namespace Com.Zipow.Videobox.View.MM.Sticker
{
    public partial class CommonEmojiAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }
}

namespace Com.Zipow.Videobox.View.Sip
{
    public partial class SipInCallPanelAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }
    public partial class SharedLineAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter, global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.IPinnedSectionAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }
    public partial class ContactPBXNumberAdapter : global::Android.Widget.BaseAdapter
    {
        public override Java.Lang.Object GetItem(int position)
        {
            return GetExItem(position);
        }
    }
}

namespace Com.Zipow.Videobox.View.Sip.Sms
{
    public partial class PBXMessageSessionMemberAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }

    public partial class PhonePBXMessageSessionAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter, global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.IPinnedSectionAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }

}
namespace Com.Zipow.Videobox.View.MM.Message
{
    public partial class ReactionContextMenuListAdapter : global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter, global::Com.Zipow.Videobox.View.MM.ReactionEmojiSampleView.IOnReactionEmojiSampleListener
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OnExBindViewHolder((global::US.Zoom.Androidlib.Widget.Pinnedsectionrecyclerview.BaseRecyclerViewAdapter.BaseViewHolder)holder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return OnExCreateViewHolder(parent, viewType);
        }
    }
}

namespace Com.Zipow.Videobox.Fragment.Meeting.QA
{
    public partial class ZMQAAttendeeViewerAdapter : global::US.Zoom.Androidlib.Widget.Recyclerview.ZMBaseMultiItemRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new NotImplementedException();
        }

        protected override void Convert(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            throw new NotImplementedException();
        }
    }

    public partial class ZMQAPanelistViewerAdapter : global::US.Zoom.Androidlib.Widget.Recyclerview.ZMBaseMultiItemRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new NotImplementedException();
        }

        protected override void Convert(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            throw new NotImplementedException();
        }
    }
}