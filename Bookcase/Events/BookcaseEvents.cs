﻿using System;

namespace Bookcase.Events {

    public static class BookcaseEvents {

        /// <summary>
        /// This event is fired when an item tooltip is displayed.
        /// </summary>
        public static EventBus<TooltipEvent> OnTooltip = new EventBus<TooltipEvent>();
    }
}