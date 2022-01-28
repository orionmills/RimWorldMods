using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace OrioM_SickGun
{
    public class Projectile_PlagueBullet : Bullet //inherit bullet class
    {
        public ModExtension_SickBullet Props => def.GetModExtension<ModExtension_SickBullet>();

        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            if (Props != null && hitThing != null && hitThing is Pawn hitPawn) //check that anything is hit and that a pawn is hit
            {
                float rand = Rand.Value;
                if (rand <= Props.addHediffChance) //roll if hediff is applied
                {
                    Messages.Message("OrioM_PlagueBullet_SuccessMessage".Translate( //print success message (SickGun_Keys.xml)
                        this.launcher.Label, hitPawn.Label
                    ), MessageTypeDefOf.NeutralEvent);
                    Hediff sickOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Props.hediffToAdd); //check for hediff
                    float randomSeverity = Rand.Range(0.15f, 0.30f);
                    if (sickOnPawn != null)
                    {
                        sickOnPawn.Severity += randomSeverity; //if hediff already applied, increase severity 
                    }
                    else
                    {
                        Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn); //if new, apply hediff
                        hediff.Severity = randomSeverity;
                        hitPawn.health.AddHediff(hediff);
                    }
                }
                else
                {
                    MoteMaker.ThrowText(hitThing.PositionHeld.ToVector3(), hitThing.MapHeld, "OrioM_SickBullet_FailureMote".Translate(Props.addHediffChance), 12f); //print failure mote over target (SickGun_Keys.xml)
                }
            }
        }
    }
    public class Projectile_PunjiBullet : Bullet //inherit bullet class
    {
        public ModExtension_SickBullet Props => def.GetModExtension<ModExtension_SickBullet>();

        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            if (Props != null && hitThing != null && hitThing is Pawn hitPawn) //check that anything is hit and that a pawn is hit
            {
                float rand = Rand.Value;
                if (rand <= Props.addHediffChance) //roll if hediff is applied
                {
                    Messages.Message("OrioM_PunjiBullet_SuccessMessage".Translate( //print success message (SickGun_Keys.xml)
                        this.launcher.Label, hitPawn.Label
                    ), MessageTypeDefOf.NeutralEvent);
                    Hediff sickOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Props.hediffToAdd); //check for hediff
                    float randomSeverity = Rand.Range(0.15f, 0.30f);
                    if (sickOnPawn != null)
                    {
                        sickOnPawn.Severity += randomSeverity; //if hediff already applied, increase severity 
                    }
                    else
                    {
                        Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn); //if new, apply hediff
                        hediff.Severity = randomSeverity;
                        hitPawn.health.AddHediff(hediff);
                    }

                }
                else
                {
                    MoteMaker.ThrowText(hitThing.PositionHeld.ToVector3(), hitThing.MapHeld, "OrioM_SickBullet_FailureMote".Translate(Props.addHediffChance), 12f); //print failure mote over target (SickGun_Keys.xml)
                }
            }
        }
    }
    public class Projectile_FluBullet : Bullet //inherit bullet class
    {
        public ModExtension_SickBullet Props => def.GetModExtension<ModExtension_SickBullet>();

        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            if (Props != null && hitThing != null && hitThing is Pawn hitPawn) //check that anything is hit and that a pawn is hit
            {
                float rand = Rand.Value;
                if (rand <= Props.addHediffChance) //roll if hediff is applied
                {
                    Messages.Message("OrioM_FluBullet_SuccessMessage".Translate( //print success message (SickGun_Keys.xml)
                        this.launcher.Label, hitPawn.Label
                    ), MessageTypeDefOf.NeutralEvent);
                    Hediff sickOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Props.hediffToAdd); //check for hediff
                    float randomSeverity = Rand.Range(0.15f, 0.30f);
                    if (sickOnPawn != null)
                    {
                        sickOnPawn.Severity += randomSeverity; //if hediff already applied, increase severity 
                    }
                    else
                    {
                        Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn); //if new, apply hediff
                        hediff.Severity = randomSeverity;
                        hitPawn.health.AddHediff(hediff);
                    }
                }
                else
                {
                    MoteMaker.ThrowText(hitThing.PositionHeld.ToVector3(), hitThing.MapHeld, "OrioM_SickBullet_FailureMote".Translate(Props.addHediffChance), 12f); //print failure mote over target (SickGun_Keys.xml)
                }
            }
        }
    }
}
