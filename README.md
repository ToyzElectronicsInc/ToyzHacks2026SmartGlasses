# ToyzHacks 2026 — Build the Smart Glasses ⚡

**April 4, 2026 · 11am–3pm ET · Virtual + Carnegie Mellon University**
**Submissions due: April 7, 2026**

Top candidates featured on the DahVarsity leaderboard during CMU Carnival Weekend (April 8–11) — shared with our recruiter network including corporate contacts worldwide.

---

## The Challenge

You're on Space Station Zenith-9. Your AR smart glasses are broken. Build the power management circuit that brings them back online.

Three tiers. One mission. Anyone can compete.

---

## Tier 1 — Browser Challenge (2 Hours · Anyone)

**No Unity required.**

Build an interactive HTML/JS simulation of the Smart Glasses Mission 1 power circuit. Your simulation should teach RC circuit fundamentals — the same physics behind every wearable device with power management.

**What to submit:**
- A single self-contained HTML file (with inline CSS and JS)
- Place it in `/Tier1/your-github-username/index.html`
- Submit a pull request with the title: `[Tier1] Your Name — School Name`

**Requirements:**
- Must include at least one interactive element (slider, input, button)
- Must demonstrate RC circuit behavior (charging/discharging, time constant)
- Must have a space station narrative frame — you're repairing something
- No external dependencies that require a server. Must open directly in a browser.

**Reference:** The DahVarsity L8 RC Circuits lesson is the conceptual foundation. The challenge is to build your own version of a circuit simulator — not copy ours.

---

## Tier 2 — Unity DLC Component (4 Hours · Unity Experience)

**Fork this repo. Build a 3D component prefab.**

Create a physical electronic component — a capacitor, a PMIC board, a battery module, a resistor array — that a player can grab and place in the Smart Glasses workbench scene inside DahVarsity.

**What to submit:**
- A Unity prefab following the ScriptableObject architecture rules below
- Place your files in `/Tier2/your-github-username/`
- Submit a pull request with the title: `[Tier2] Your Name — School Name`

**Architecture rules (must follow):**
- ScriptableObject pattern — no `FindObjectOfType`, no static classes
- New prefabs go in `Assets/DahVarsityV2/UI/Prefabs/` as siblings — never nested
- Edit prefabs in Prefab Edit Mode only — never on Hierarchy instances
- Reference `GlassesComponentDataSO` for component data — do not hardcode values

**Reference:** See the previous hackathon repo ([ToyzHacks 2025](https://github.com/ToyzElectronicsInc/ToyzHacks2025DahVarsity)) for accepted PR examples — avatar submissions with 5 commits, clear component behavior, WASD controls.

---

## Tier 3 — Full Mission Integration (Beyond the Event · Advanced)

Wire your Tier 2 component to `SmartGlassesLevel.cs`, fire the correct PlayFab telemetry events, and submit for admin dashboard approval. Your contribution becomes permanent DLC in the game.

**Telemetry events to fire:**
- `component_placed` — when the component snaps into the workbench slot
- `circuit_completed` — when the full circuit is valid

This tier has no deadline — open submissions reviewed on a rolling basis.

---

## How to Submit

1. Fork this repo
2. Create your folder: `/Tier1/your-github-username/` or `/Tier2/your-github-username/`
3. Add your files
4. Open a pull request with the correct title format
5. Fill in the PR template (auto-appears when you open a PR)

**Register first:** [dahvarsityai.com/register-hack2026](https://dahvarsityai.com/register-hack2026)

---

## Previous Hackathon

[ToyzHacks 2025 — Avatar & Superpowers Challenge](https://github.com/ToyzElectronicsInc/ToyzHacks2025DahVarsity)
24+ forks. Accepted DLC submissions from universities across the country. Avatar creation, C#, 3D design, superpower abilities.

---

## Watch Live

Twitch: [twitch.tv/dahvarsity](https://twitch.tv/dahvarsity)

---

## Questions

Open a GitHub Discussion or DM [@DahVarsityAI](https://twitter.com/toyzelectronics) on X.

*Hosted by Wole Idowu — CMU ECE Alum, CTO of DahVarsity AI, CMU Robotics Institute Pathways Fellow.*
