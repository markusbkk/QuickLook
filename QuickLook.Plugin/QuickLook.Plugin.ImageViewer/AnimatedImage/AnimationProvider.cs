﻿// Copyright © 2017 Paddy Xu
// 
// This file is part of QuickLook program.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace QuickLook.Plugin.ImageViewer.AnimatedImage
{
    internal abstract class AnimationProvider : IDisposable
    {
        protected AnimationProvider(string path, Dispatcher uiDispatcher)
        {
            Path = path;
            Dispatcher = uiDispatcher;
        }

        public Dispatcher Dispatcher { get; }

        public string Path { get; }

        public Int32Animation Animator { get; protected set; }

        public abstract void Dispose();

        public abstract ImageSource GetRenderedFrame(int index);
    }
}