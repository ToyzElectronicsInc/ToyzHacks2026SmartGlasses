# Contributing to ToyzHacks 2026

**Submissions close: April 9, 2026 · 11:59pm ET**
Leaderboard goes live April 10 during CMU Carnival Weekend.

---

## How to Submit

### Everyone (all tiers)

1. **Fork** this repository
2. **Create a branch** named `submission/your-github-handle`
   ```
   git checkout -b submission/wole-idowu
   ```
3. **Build your submission** in the appropriate folder (see tier guide below)
4. **Open a Pull Request** to `main` with the title:
   ```
   [TIER 1] Your Name — Brief description
   ```
   Example: `[TIER 1] Wole Idowu — RC filter oscilloscope with ripple calculator`

5. **Fill out the PR template** — it will appear automatically when you open a PR

---

## Tier 1 — Browser Challenge (2 hours · No Unity required)

**What to build:** An interactive HTML/JS simulation of the Smart Glasses Mission 1 power circuit.

**Starting point:** `starter/index.html` — a working skeleton with the prediction gate, component picker, and oscilloscope already structured. Modify it, extend it, or start fresh. Either is valid.

**Folder:** Put your file at `submissions/tier1/your-github-handle/index.html`

**What good looks like:**
- Student calculates minimum capacitance *before* the simulation unlocks (prediction gate)
- Oscilloscope or waveform shows voltage ripple changing with component values
- Clear pass/fail state when the circuit meets spec
- Works in a browser with no install

**Skills demonstrated:** RC circuits, power management, HTML/JS, engineering documentation

---

## Tier 2 — Unity DLC Component (4 hours · Unity experience helpful)

**What to build:** A 3D prefab for a smart glasses electronic component that can be placed in the DahVarsity space station workbench scene.

**Architecture rules (required):**
- ScriptableObject pattern — no `FindObjectOfType` or static classes
- Prefab goes in `submissions/tier2/your-github-handle/`
- Include a `README.md` explaining what the component does and how it integrates
- All MonoBehaviours should reference SOs, not other scene objects directly

**What good looks like:**
- Prefab follows the SO architecture pattern (see `docs/ArchitectureGuide.md`)
- Component has a clear visual representation in the scene
- Includes at minimum one ScriptableObject config file
- PR includes a short screen recording or screenshot

**Skills demonstrated:** C# / Unity, ScriptableObject architecture, 3D prefab design

---

## Tier 3 — Full Mission Integration (beyond the event · Advanced)

**What to build:** Wire a component to `SmartGlassesLevel.cs`, fire behavioral telemetry events to Azure PlayFab, and submit for admin dashboard approval.

This tier has no hard deadline — approved integrations become permanent DLC in the game.

Contact `wole@toyzteam.us` before starting Tier 3.

---

## PR Template

When you open a PR, fill this out:

```markdown
## Submission — ToyzHacks 2026

**Name:**
**GitHub handle:**
**Tier:** [ ] Tier 1  [ ] Tier 2  [ ] Tier 3
**University / Org:**

### What I built
<!-- 2-3 sentences -->

### How to run it
<!-- For Tier 1: open index.html in browser. For Tier 2: import prefab into Unity 6.x -->

### What I'd add with more time
<!-- Optional but useful for reviewer feedback -->

### DahVarsity profile (optional)
<!-- Link to your profile at dahvarsityai.com if you want recruiter visibility -->
```

---

## Scoring

Submissions are reviewed by the DahVarsity team and scored on:

| Criterion | Weight |
|---|---|
| Circuit accuracy (does the EE work?) | 40% |
| Anti-gaming (can it be completed without understanding?) | 25% |
| Code quality / architecture | 20% |
| Documentation / PR quality | 15% |

Top submissions go live on the [DahVarsity leaderboard](https://dahvarsityai.com) April 10.

---

## Questions

- GitHub Issues on this repo
- Discord: [link in bio at twitch.tv/dahvarsity](https://twitch.tv/dahvarsity)
- Email: `wole@toyzteam.us`

Kickoff VOD (April 4 stream with SHPE + ColorStack chapter presidents):
https://www.twitch.tv/videos/2739889621
