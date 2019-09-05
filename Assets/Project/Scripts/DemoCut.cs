using System;
using System.Collections;
using System.Collections.Generic;
using Spine;
using Spine.Unity;
using UnityEngine;

public class DemoCut : MonoBehaviour {
  [SerializeField] private SkeletonGraphic skeletonGraphic;

  private void Start() {
    TrackEntry trackEntry = skeletonGraphic.AnimationState.SetAnimation(0, "animation", true);
    trackEntry.AnimationStart = (float) 80 / 30;
    trackEntry.AnimationEnd = (float) 120 / 30;
  }
}